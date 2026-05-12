using System;
using System.Collections.Generic;
using MelonLoader;

namespace Euterpe.Core
{
    /// <summary>
    /// Euterpe 多语言框架 (i18n)
    /// 
    /// 使用 ISO 标准语言代码作为内部标识，兼容游戏内设置与未来 App/Web 平台。
    /// 
    /// 支持的语言代码:
    ///   "en"    = 英文         (游戏ID: 1)
    ///   "zh-CN" = 简体中文     (游戏ID: 0, 2)
    ///   "zh-TW" = 繁体中文     (游戏ID: 3)
    ///   "ja"    = 日文         (游戏ID: 4)
    ///   "ko"    = 韩文         (游戏ID: 5)
    /// 
    /// 新增语言只需:
    ///   1. 在 Register() 便捷方法中添加新参数
    ///   2. 在 RegisterAllStrings() 的每条 Register() 调用中补上对应翻译
    /// 
    /// 外部平台对接:
    ///   - App/Web 端可直接调用 I18n.SetLanguage("ja") 来覆盖语言
    ///   - 也可通过 API 下发语言代码后调用 SetLanguage() 实现云端控制
    ///   - 翻译键名全局统一，Mod / App / Web 可共享同一套翻译体系
    /// </summary>
    public static class I18n
    {
        // 当前激活的语言代码
        private static string _currentLang = "en";

        // 游戏内语言ID → 标准语言代码 映射表
        private static readonly Dictionary<int, string> _gameIdToLangCode = new Dictionary<int, string>
        {
            { 0, "zh-CN" },  // 简体中文
            { 1, "en" },     // 英文
            { 2, "zh-CN" },  // 简体中文 (重复ID)
            { 3, "zh-TW" },  // 繁体中文
            { 4, "ja" },     // 日文
            { 5, "ko" },     // 韩文
        };

        // 主翻译字典: 翻译键 → { 语言代码 → 翻译文本 }
        private static readonly Dictionary<string, Dictionary<string, string>> _strings
            = new Dictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// 初始化多语言系统：检测游戏语言并注册所有翻译条目。
        /// 在 Mod 初始化期间（游戏数据库就绪后）调用一次即可。
        /// </summary>
        public static void Initialize()
        {
            RegisterAllStrings();
            DetectLanguage();
            MelonLogger.Msg($"[Euterpe I18n] Initialized. Language: {_currentLang}");
        }

        /// <summary>
        /// 从游戏全局数据库检测当前语言设置，并映射为标准语言代码。
        /// </summary>
        public static void DetectLanguage()
        {
            try
            {
                var langEnum = Il2CppAssets.Scripts.Database.GlobalDataBase.s_DbUi.curLanguageIndex;
                int gameId = (int)langEnum;

                if (_gameIdToLangCode.TryGetValue(gameId, out var code))
                    _currentLang = code;
                else
                    _currentLang = "en"; // 未知ID回退到英文
            }
            catch (Exception)
            {
                _currentLang = "en";
            }
        }

        /// <summary>
        /// 手动设置语言代码。
        /// 供 App/Web 端或远程 API 下发语言时使用。
        /// 示例: I18n.SetLanguage("ja")
        /// </summary>
        public static void SetLanguage(string langCode)
        {
            _currentLang = langCode;
            MelonLogger.Msg($"[Euterpe I18n] Language overridden to: {_currentLang}");
        }

        /// <summary>
        /// 获取当前语言代码 (如 "en", "zh-CN", "ja" 等)。
        /// </summary>
        public static string CurrentLanguage => _currentLang;

        /// <summary>
        /// 获取所有已支持的语言代码列表。
        /// 可供 App/Web 端获取可用语言选项。
        /// </summary>
        public static List<string> SupportedLanguages => new List<string> 
        { 
            "en", "zh-CN", "zh-TW", "ja", "ko" 
        };

        /// <summary>
        /// 根据键名获取当前语言的翻译文本。
        /// 回退策略: 当前语言 → 英文 → 返回键名本身。
        /// </summary>
        public static string Get(string key)
        {
            if (_strings.TryGetValue(key, out var langDict))
            {
                // 尝试当前语言
                if (langDict.TryGetValue(_currentLang, out var result))
                    return result;

                // 回退到英文
                if (langDict.TryGetValue("en", out var en))
                    return en;
            }

            // 最终兜底: 直接返回键名
            return key;
        }

        /// <summary>
        /// 获取指定语言的翻译文本（不受当前语言影响）。
        /// 供 App/Web 端渲染其他语言版本时使用。
        /// 示例: I18n.Get("update.available", "ja")
        /// </summary>
        public static string Get(string key, string langCode)
        {
            if (_strings.TryGetValue(key, out var langDict))
            {
                if (langDict.TryGetValue(langCode, out var result))
                    return result;
                if (langDict.TryGetValue("en", out var en))
                    return en;
            }
            return key;
        }

        /// <summary>
        /// 获取带格式化参数的翻译文本。
        /// 翻译文本中使用 {0}, {1} 等占位符。
        /// 示例: I18n.GetFormatted("score.format", 999, 98.5)
        /// </summary>
        public static string GetFormatted(string key, params object[] args)
        {
            string template = Get(key);
            try
            {
                return string.Format(template, args);
            }
            catch (FormatException)
            {
                return template;
            }
        }

        /// <summary>
        /// 导出所有翻译数据为字典格式。
        /// 供未来 App/Web 端批量拉取翻译资源时使用。
        /// 返回格式: { "键名": { "语言代码": "翻译文本" } }
        /// </summary>
        public static Dictionary<string, Dictionary<string, string>> ExportAll()
        {
            return new Dictionary<string, Dictionary<string, string>>(_strings);
        }

        // ==================== 内部注册方法 ====================

        /// <summary>
        /// 注册单条翻译条目。
        /// </summary>
        private static void Register(string key, string langCode, string value)
        {
            if (!_strings.ContainsKey(key))
                _strings[key] = new Dictionary<string, string>();
            _strings[key][langCode] = value;
        }

        /// <summary>
        /// 便捷注册方法：一次性注册一个键的所有语言翻译。
        /// 新增语言时，在此方法签名中添加新参数即可。
        /// </summary>
        private static void Register(string key, string en, string zhCn, string zhTw, string ja, string ko)
        {
            Register(key, "en", en);
            Register(key, "zh-CN", zhCn);
            Register(key, "zh-TW", zhTw);
            Register(key, "ja", ja);
            Register(key, "ko", ko);
        }

        // ==================== 翻译文本注册区 ====================
        // 在此集中管理所有翻译条目。
        // 新增文案只需添加一条 Register() 调用即可。

        private static void RegisterAllStrings()
        {
            // ---------- 更新弹窗 ----------
            Register("update.available",
                en:   "Mod updates available.\nProceed to the <color=#42A5F5>Euterpe</color> desktop client to update?",
                zhCn: "有MOD更新可用\n是否前往<color=#42A5F5>Euterpe</color>桌面端进行更新？",
                zhTw: "有MOD更新可用\n是否前往<color=#42A5F5>Euterpe</color>桌面端進行更新？",
                ja:   "MODの更新があります。\n<color=#42A5F5>Euterpe</color> デスクトップで更新しますか？",
                ko:   "모드 업데이트가 있습니다.\n<color=#42A5F5>Euterpe</color> 데스크톱에서 업데이트하시겠습니까?"
            );

            // ---------- 通用 UI ----------
            Register("ui.confirm",
                en:   "Confirm",
                zhCn: "确认",
                zhTw: "確認",
                ja:   "確認",
                ko:   "확인"
            );

            Register("ui.cancel",
                en:   "Cancel",
                zhCn: "取消",
                zhTw: "取消",
                ja:   "キャンセル",
                ko:   "취소"
            );

            // ---------- 排行榜 ----------
            Register("leaderboard.loading",
                en:   "Loading leaderboard...",
                zhCn: "正在加载排行榜...",
                zhTw: "正在載入排行榜...",
                ja:   "ランキング読み込み中...",
                ko:   "리더보드 로딩 중..."
            );

            Register("leaderboard.empty",
                en:   "No scores submitted yet. Be the first!",
                zhCn: "还没有人提交过成绩，来做第一个吧！",
                zhTw: "還沒有人提交過成績，來做第一個吧！",
                ja:   "まだスコアが提出されていません。最初の一人になろう！",
                ko:   "아직 점수가 제출되지 않았습니다. 첫 번째가 되어보세요!"
            );

            Register("leaderboard.error",
                en:   "Failed to load leaderboard.",
                zhCn: "排行榜加载失败。",
                zhTw: "排行榜載入失敗。",
                ja:   "ランキングの読み込みに失敗しました。",
                ko:   "리더보드 로딩에 실패했습니다."
            );

            // ---------- 视频背景 (Cinema) ----------
            Register("cinema.toggled",
                en:   "Cinema: {0}",
                zhCn: "视频播放: {0}",
                zhTw: "影片播放: {0}",
                ja:   "シネマ: {0}",
                ko:   "시네마: {0}"
            );

            Register("cinema.on",
                en:   "ON",
                zhCn: "已开启",
                zhTw: "已開啟",
                ja:   "オン",
                ko:   "켜짐"
            );

            Register("cinema.off",
                en:   "OFF",
                zhCn: "已关闭",
                zhTw: "已關閉",
                ja:   "オフ",
                ko:   "꺼짐"
            );
        }
    }
}

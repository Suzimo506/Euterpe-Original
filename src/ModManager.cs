using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Il2CppUI.Controls; 
using Il2CppAssets.Scripts.UI.Panels; 
using Il2CppArcadeController.UI.Panel.PnlHome; //原生大厅主控实体以定位游戏场景生命周期
using Il2CppInterop.Runtime; //提供 C# 托管域与 C++ 本机实例间的安全指针传递与委托封装
using HarmonyLib; //负责运行时方法拦截与字节码劫持
using UnityEngine.Networking; //提供异步 HTTP 请求支持
using System.Collections; //提供协程 IEnumerator 支持
using Euterpe.CustomAlbums;
using Euterpe.CustomAlbums.Managers;
using Euterpe.CustomAlbums.Patches;
using static Euterpe.CustomAlbums.Patches.AnimatedCoverPatch;

namespace Euterpe
{
    public class ModManager : MelonMod
    {
        // ----- 本地配置项持久化声明 -----
        private static MelonPreferences_Category _configCategory;
        public static MelonPreferences_Entry<bool> EnableUpdatePopup;

        private static System.Action _onConfirmAction;
        private static System.Action _onCancelAction;
        private static Il2CppSystem.Action _il2cppConfirm;
        private static Il2CppSystem.Action _il2cppCancel;

        // 全局 UI 互斥锁。此处激活拦截器，用于在更新提示显示期间内，拒载后续引擎原生其他堆栈发起的弹窗请求。
        public static bool IsPopupLockActive = false;

        // 确保单次 Session 生命周期内的版本侦测行为只执行且严格完成一次。
        internal bool _hasCheckedUpdate = false;

        // 静态单例暴露，供静态拦截器回访
        public static ModManager Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("Euterpe Auto-Updater Core System Initialized!");

            // 需依照 MelonLoader 标准进行 IO 的落盘。如果宿主本地尚无 UserData 定义环境，将隐式生成并载入默认属性。
            _configCategory = MelonPreferences.CreateCategory("Euterpe");
            EnableUpdatePopup = _configCategory.CreateEntry<bool>("EnableAutoUpdateCheck", true);

            // ===== CustomAlbums 初始化链 =====
            if (!Directory.Exists(AlbumManager.SearchPath)) Directory.CreateDirectory(AlbumManager.SearchPath);
            ModSettings.Register();
            AssetPatch.AttachHook();
            SavePatch.AttachHook();
            AlbumManager.LoadAlbums();
            SaveManager.LoadSaveFile();
            LoggerInstance.Msg("Initialized CustomAlbums!");
            // ===== CustomAlbums 初始化完成 =====

            // 确认回调：唤起外置更新程序并中止当前游戏进程。
            _onConfirmAction = new System.Action(() =>
            {
                IsPopupLockActive = false; // 释放拦截锁
                LoggerInstance.Msg("============ [ Euterpe Interaction ] ============");
                LoggerInstance.Msg("-> User Action: Action [CONFIRM] dispatched successfully.");
                LoggerInstance.Msg("-> Result: Launching Euterpe Updater DeepLink protocol & Terminating current Game Process.");
                LoggerInstance.Msg("=================================================");
                Application.OpenURL("Euterpe://go/modding/manage");
                Application.Quit();
            });

            // 取消回调：注销拦截锁并恢复游戏。
            _onCancelAction = new System.Action(() =>
            {
                IsPopupLockActive = false; // 释放拦截锁
                LoggerInstance.Msg("============ [ Euterpe Interaction ] ============");
                LoggerInstance.Msg("-> User Action: Action [CANCEL] or Panel Dismissed by user.");
                LoggerInstance.Msg("-> Result: Alert Panel Terminated. Resuming main thread logic.");
                LoggerInstance.Msg("=================================================");
            });

            _il2cppConfirm = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(_onConfirmAction);
            _il2cppCancel = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(_onCancelAction);

            // 启动页面探测协程
            MelonCoroutines.Start(WaitForHomePage());
        }

        public override void OnLateInitializeMelon()
        {
            // 在所有 Mod 都初始化并打完补丁后
            Headquarters.Init();

            // TODO: HotReload temporarily disabled until UI interaction issues are fully resolved.
            /*
            // 启动热重载文件监控
            try
            {
                LoggerInstance.Msg("Starting HotReload initialization...");
                HotReloadManager.OnLateInitializeMelon();
            }
            catch (Exception ex)
            {
                LoggerInstance.Error($"HotReload init failed: {ex.Message}");
                LoggerInstance.Error(ex.StackTrace);
            }
            */
        }

        public override void OnFixedUpdate()
        {
            // CustomAlbums: 处理热重载队列（仅在选歌界面触发）
            // TODO: HotReload temporarily disabled
            // HotReloadManager.FixedUpdate();
        }

        public override void OnUpdate()
        {
            // CustomAlbums: 驱动动态封面帧动画
            MusicStageCellPatch.AnimateCoversUpdate();

            // 焦点重定向补丁
            if (IsPopupLockActive && CommonMessageBox.s_Instance != null)
            {
                // 触发首位按钮（确认）
                if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    if (CommonMessageBox.s_Instance.m_BtnLayoutRects.Length > 0)
                    {
                        var confirmBtn = CommonMessageBox.s_Instance.m_BtnLayoutRects[0].GetComponent<UnityEngine.UI.Button>();
                        if (confirmBtn != null) confirmBtn.onClick.Invoke();
                    }
                }
                // 触发次位按钮（取消）
                else if (Input.GetKeyDown(KeyCode.Escape))
                {
                    if (CommonMessageBox.s_Instance.m_BtnLayoutRects.Length > 1)
                    {
                        var cancelBtn = CommonMessageBox.s_Instance.m_BtnLayoutRects[1].GetComponent<UnityEngine.UI.Button>();
                        if (cancelBtn != null) cancelBtn.onClick.Invoke();
                    }
                }
            }
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
            // CustomAlbums: 追踪当前场景（用于封面动画控制）
            MusicStageCellPatch.CurrentScene = sceneName;
        }

        // 提取模块信息并推送比对。
        internal void VerifyVersionsTrigger()
        {
            // 启动异步协程，彻底解耦网络请求与游戏主渲染线程
            MelonCoroutines.Start(FetchApiCoroutine());
        }

        private IEnumerator FetchApiCoroutine()
        {
            LoggerInstance.Msg("=========== Euterpe Scanner Started ===========");

            var installedMods = new System.Collections.Generic.Dictionary<string, string>();

            // 将自更新模块作为强行入列排查对象。
            installedMods[this.Info.Name] = this.Info.Version;
            LoggerInstance.Msg($"[+] {this.Info.Name} (v{this.Info.Version})");

            // 遍历并压入运行池内其他活跃 Mod 信息供全盘更新扫描。
            foreach (var mod in MelonMod.RegisteredMelons)
            {
                if (!installedMods.ContainsKey(mod.Info.Name))
                {
                    installedMods.Add(mod.Info.Name, mod.Info.Version);
                    LoggerInstance.Msg($"[+] {mod.Info.Name} (v{mod.Info.Version})");
                }
            }

            // 远端 API 终点
            string apiUrl = "https://Euterpe.example.com/api/v1/update"; // TODO: 替换为真实的远端配置 URL
            LoggerInstance.Msg($"[+] Dispatching Async Request to: {apiUrl}");

            // 发起异步 HTTP GET 请求
            var request = UnityWebRequest.Get(apiUrl);
            yield return request.SendWebRequest();

            bool requiresUpdate = false;

            if (!request.isNetworkError && !request.isHttpError)
            {
                // TODO: 填写 API 响应解析逻辑
                LoggerInstance.Msg("-> Payload retrieved successfully. Parsing API parameters...");
            }
            else
            {
                LoggerInstance.Error($"API Request Failed: {request.error}");
            }

            // 测试强制触发更新弹窗
            requiresUpdate = true; 

            LoggerInstance.Msg("=========== Euterpe Scanner Completed ===========");

            if (requiresUpdate)
            {
                // Initialize i18n (detects game language automatically)
                I18n.Initialize();
                
                string msgBuilder = I18n.Get("update.available");

                CommonMessageBox.ShowConfrimAndCancelWithShut(msgBuilder, _il2cppConfirm, _il2cppCancel);

                // 保障弹窗唯一抢占焦点。
                IsPopupLockActive = true; 
            }
        }

        // 通过协程按秒轮询
        private IEnumerator WaitForHomePage()
        {
            while (!_hasCheckedUpdate)
            {
                // 如果配置文件控制中关闭了更新，则直接斩断探测循环。
                if (!EnableUpdatePopup.Value)
                {
                    _hasCheckedUpdate = true;
                    yield break; 
                }

                var homePage = UnityEngine.Object.FindObjectOfType<PageHome>();
                if (homePage != null && homePage.gameObject.activeInHierarchy)
                {
                    _hasCheckedUpdate = true;
                    VerifyVersionsTrigger();
                    yield break;
                }
                
                // 等待进入大厅过程中，每隔 1 秒检测一次
                yield return new WaitForSeconds(1f);
            }
        }
    }

    // ================== Sub-System Interceptor Directives (本机端拦截服务) ==================
    
    // 切片挂载一：拦截带有进程关闭属性的原生请求框。
    [HarmonyPatch(typeof(CommonMessageBox), nameof(CommonMessageBox.ShowConfrimAndCancelWithShut))]
    public class InterceptMessageBox_WithShut
    {
        public static bool Prefix()
        {
            // 视当前挂起标记返回 false 进行原生执行流切断。
            return !ModManager.IsPopupLockActive; 
        }
    }

    // 切片挂载二：拦截常规标准原生确认框。
    [HarmonyPatch(typeof(CommonMessageBox), nameof(CommonMessageBox.ShowConfrimAndCancel))]
    public class InterceptMessageBox_Normal
    {
        public static bool Prefix()
        {
            return !ModManager.IsPopupLockActive;
        }
    }
}
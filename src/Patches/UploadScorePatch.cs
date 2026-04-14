using System;
using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using Il2CppAccount;
using Il2CppAssets.Scripts.Common;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(GameAccountSystem), "UploadScore")]
    public class UploadScorePatch
    {
        // 原版签名: SceneUploadResultData resData, List<Beat> beats
        // 只接收关心的参数 resData
        public static bool Prefix(SceneUploadResultData resData)
        {
            if (!resData.musicUid.StartsWith("999"))
            {
                return true; // 交给游戏原逻辑上传官方服
            }

            MelonLogger.Msg($"[Euterpe] Intercepted score upload request: UID={resData.musicUid}, Score={resData.score}");

            // TODO: 构建上传的 Dictionary 提交给你自己的服务器
            // 比如: 
            // var data = new Dictionary<string, string>();
            // data["score"] = resData.score.ToString();
            // ...
            // Web.Post(api_url, data, callback...);

            return false; // 拦截完毕，阻断原始逻辑
        }
    }
}

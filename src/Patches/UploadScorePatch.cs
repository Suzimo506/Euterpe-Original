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
        // Intercepts the score upload request
        public static bool Prefix(SceneUploadResultData resData)
        {
            if (!resData.musicUid.StartsWith("999"))
            {
                return true; // Allow native game logic to handle official score uploads
            }

            MelonLogger.Msg($"[Euterpe] Intercepted score upload request: UID={resData.musicUid}, Score={resData.score}");

            // TODO: Implement custom server score upload logic here

            return false; // Prevent original upload logic
        }
    }
}

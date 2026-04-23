using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using Il2CppAccount;
using Il2CppAssets.Scripts.Common;
using Il2CppNewtonsoft.Json.Linq;
using Euterpe.CustomAlbums.Managers;

namespace Euterpe
{
    public class Headquarters
    {
        // Entry point for Headquarters module
        public static void Init()
        {
            MelonLogger.Msg("Headquarters initialized.");
            HijackOriginalHeadquarters();
        }

        private static void HijackOriginalHeadquarters()
        {
            var hqMod = MelonMod.RegisteredMelons.FirstOrDefault(m => m.Info.Name == "Headquarters" || m.MelonAssembly.Assembly.GetName().Name == "Headquarters");
            
            if (hqMod != null)
            {
                MelonLogger.Msg("[Euterpe] Native Headquarters Mod detected. Intercepting leaderboard control...");
                
                try
                {
                    string hqHarmonyId = hqMod.HarmonyInstance.Id;

                    // Retrieve all methods currently patched by Harmony
                    var patchedMethods = HarmonyLib.Harmony.GetAllPatchedMethods();
                    var targetPatchClasses = new List<string> { 
                        "GetRanksPatch", 
                        "UiRefreshPatch", 
                        "UploadScorePatch",
                        "GetPanelInfo",
                        "FavoritesPatch"
                    };

                    int removedCount = 0;

                    foreach (var method in patchedMethods)
                    {
                        var patchInfo = HarmonyLib.Harmony.GetPatchInfo(method);
                        if (patchInfo == null) continue;

                        var hqPrefixes = patchInfo.Prefixes.Where(p => p.owner == hqHarmonyId);
                        var hqPostfixes = patchInfo.Postfixes.Where(p => p.owner == hqHarmonyId);

                        // Unpatch Prefixes
                        foreach (var prefix in hqPrefixes)
                        {
                            var patchClassName = prefix.PatchMethod.DeclaringType?.Name;
                            if (patchClassName == "GetRanksPatch" || patchClassName == "UploadScorePatch" || patchClassName == "FavoritesPatch")
                            {
                                ModManager.Instance.HarmonyInstance.Unpatch(method, HarmonyPatchType.Prefix, hqHarmonyId);
                                MelonLogger.Msg($"[Euterpe] Successfully unpatched Headquarters Prefix: {method.Name} (from {patchClassName})");
                                removedCount++;
                            }
                        }

                        // Unpatch Postfixes
                        foreach (var postfix in hqPostfixes)
                        {
                            var patchClassName = postfix.PatchMethod.DeclaringType?.Name;
                            if (patchClassName == "GetRanksPatch" || patchClassName == "UploadScorePatch" || patchClassName == "FavoritesPatch")
                            {
                                ModManager.Instance.HarmonyInstance.Unpatch(method, HarmonyPatchType.Postfix, hqHarmonyId);
                                MelonLogger.Msg($"[Euterpe] Successfully unpatched Headquarters Postfix: {method.Name} (from {patchClassName})");
                                removedCount++;
                            }
                        }
                    }

                    MelonLogger.Msg($"[Euterpe] Hijack complete! Stripped {removedCount} scoreboard/score patches from Headquarters. Euterpe is now in control!");
                }
                catch (System.Exception ex)
                {
                    MelonLogger.Error($"[Euterpe] Error while hijacking Headquarters: {ex.Message}");
                }
            }
            else
            {
                MelonLogger.Msg("[Euterpe] Headquarters mod not found. Applying Euterpe scoreboard patches directly.");
                
                try
                {
                    var harmony = ModManager.Instance.HarmonyInstance;

                    // Inject custom leaderboard patches
                    var getRanksMethod = AccessTools.Method(typeof(GameAccountSystem), "GetRanks");
                    var getRanksPrefix = new HarmonyMethod(AccessTools.Method(typeof(Euterpe.Patches.GetRanksPatch), "Prefix"));
                    if (getRanksMethod != null && getRanksPrefix.method != null)
                        harmony.Patch(getRanksMethod, prefix: getRanksPrefix);

                    MelonLogger.Msg("[Euterpe] Euterpe scoreboard injected successfully!");
                }
                catch (System.Exception ex)
                {
                    MelonLogger.Error($"[Euterpe] Failed to inject scoreboard directly: {ex.Message}");
                }
            }
        }
    }
}

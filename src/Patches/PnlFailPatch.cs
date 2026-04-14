using System;
using MelonLoader;
using HarmonyLib;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(Il2Cpp.PnlFail), "OnEnable")]
    public class PnlFailPatch
    {
        public static void Postfix()
        {
            // 通过 GlobalDataBase 获取当前游玩的谱面 UID
            string musicUid = Il2CppAssets.Scripts.Database.GlobalDataBase.dbBattleStage.musicUid;
            
            if (musicUid.StartsWith("999"))
            {
                MelonLogger.Msg($"[Euterpe] Player failed on custom chart: UID={musicUid}");
            }
            else
            {
                MelonLogger.Msg($"[Euterpe] Player failed on official chart: UID={musicUid}");
            }
        }
    }
}

using System;
using MelonLoader;
using HarmonyLib;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(Il2Cpp.PnlVictory), "SetScore")]
    public class PnlVictoryPatch
    {
        public static void Postfix()
        {
            string musicUid = Il2CppAssets.Scripts.Database.GlobalDataBase.dbBattleStage.musicUid;
            
            if (musicUid.StartsWith("999"))
            {
                MelonLogger.Msg($"[Euterpe] Player passed custom chart: UID={musicUid}");
            }
            else
            {
                MelonLogger.Msg($"[Euterpe] Player passed official chart: UID={musicUid}");
            }
        }
    }
}

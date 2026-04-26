/* 
// TODO: Implement Double Play (Tag Mode) support for custom charts
using HarmonyLib;
using Il2CppAssets.Scripts.Database;
using Il2CppGameCore.GameObjectLogics.GameObjectManager._2026FoolActivity;
using Euterpe.CustomAlbums.Managers;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(DoublePlayGameManager), nameof(DoublePlayGameManager.CheckIsDoublePlayGame))]
    internal static class DoublePlayModePatch
    {
        // Set this to true to force Double Play for testing
        public static bool ForceDoublePlay = false;

        private static bool Prefix(ref bool __result)
        {
            var musicUid = GlobalDataBase.dbBattleStage.musicUid;
            
            // Check if it's a custom album
            if (musicUid.StartsWith($"{AlbumManager.Uid}-"))
            {
                // For now, we force it for all custom albums to test the logic
                // Later we can check for a "tag_mode" flag in album info
                if (ForceDoublePlay)
                {
                    __result = true;
                    return false;
                }
            }
            return true;
        }
    }
}
*/

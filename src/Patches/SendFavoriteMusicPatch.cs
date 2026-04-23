using System;
using MelonLoader;
using HarmonyLib;
using Il2CppAccount;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(GameAccountSystem), "SendFavoriteMusic")]
    public class SendFavoriteMusicPatch
    {
        public static bool Prefix(string addMusicUid, string removeMusicUid)
        {
            if (!string.IsNullOrEmpty(addMusicUid))
            {
                if (!addMusicUid.StartsWith("999-"))
                {
                    return true; // Allow native game logic to handle official favorites
                }

                MelonLogger.Msg($"[Euterpe] Intercepted Like action for custom chart: UID={addMusicUid}");
                
                // TODO: Implement custom server favorite logic here
            }
            else if (!string.IsNullOrEmpty(removeMusicUid))
            {
                if (!removeMusicUid.StartsWith("999-"))
                {
                    return true; // Allow native game logic to handle official favorites
                }

                MelonLogger.Msg($"[Euterpe] Intercepted Unlike action for custom chart: UID={removeMusicUid}");
                
                // TODO: Implement custom server unfavorite logic here
            }

            return false; // Prevent original favorite logic
        }
    }
}

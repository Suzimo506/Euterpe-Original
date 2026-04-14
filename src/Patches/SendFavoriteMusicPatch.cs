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
                    return true; // 让游戏原版逻辑处理官方服点赞
                }

                MelonLogger.Msg($"[Euterpe] Intercepted Like action for custom chart: UID={addMusicUid}");
                
                // TODO: 接入你自己服务器的收藏/点赞功能
            }
            else if (!string.IsNullOrEmpty(removeMusicUid))
            {
                if (!removeMusicUid.StartsWith("999-"))
                {
                    return true; // 让游戏原版逻辑处理官方服取消点赞
                }

                MelonLogger.Msg($"[Euterpe] Intercepted Unlike action for custom chart: UID={removeMusicUid}");
                
                // TODO: 接入你自己服务器的取消点赞/收藏功能
            }

            return false; // 阻断原版往 PeroPero 官方发包的行为
        }
    }
}

using System;
using MelonLoader;
using HarmonyLib;
using Il2CppAccount;
using Il2CppNewtonsoft.Json.Linq;
using CustomAlbums.Managers;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(GameAccountSystem), "GetRanks")]
    public class GetRanksPatch
    {
        // 这里的 callback 类型必须严丝合缝地对齐底层的 Il2CppSystem.Action，否则 Invoke 会引发跨域崩溃。
        public static bool Prefix(string musicUid, int difficulty, Il2CppSystem.Action<JToken, JToken, int> callback, Il2CppSystem.Action<long, string> failCallback)
        {
            if (!musicUid.StartsWith("999"))
            {
                return true; // 官方库歌曲让游戏原版接管
            }

            MelonLogger.Msg($"[Euterpe] Intercepted leaderboard request for custom chart: UID={musicUid}, Diff={difficulty}");

            try
            {
                // 预留通过 CustomAlbums 获取谱面 MD5 的框架
                var album = AlbumManager.GetByUid(musicUid);
                if (album != null)
                {
                    string md5 = album.Sheets[difficulty].Md5;
                    MelonLogger.Msg($"[Euterpe] Current chart MD5: {md5}, requesting server...");
                }

                // TODO: 1. 在这里发起向你的服务器的 Get 请求
                // Web.Get(api_url + "?md5=" + md5, ...)
                
                string dummyJsonArray = @"[
                    {
                        ""play"": { ""score"": 999999, ""acc"": 100, ""combo"": 9999, ""character_uid"": ""0"", ""elfin_uid"": ""0"" },
                        ""user"": { ""nickname"": ""Euterpe"" }
                    }
                ]";
                string dummyJsonObject = @"{}"; // 本人的排行对象可以留空
                
                var jarray = JArray.Parse(dummyJsonArray);
                var jobject = JObject.Parse(dummyJsonObject);
                
                // 执行回调将伪造数据渲染到游戏 UI 排行榜中
                callback.Invoke(jarray, jobject, 0); 
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] Failed to fetch leaderboard: {ex.Message}");
                failCallback.Invoke(404L, "");
            }

            return false; // 拦截完毕，阻断原始逻辑和其他补丁
        }
    }
}

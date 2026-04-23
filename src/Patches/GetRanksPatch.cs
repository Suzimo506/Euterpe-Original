using System;
using MelonLoader;
using HarmonyLib;
using Il2CppAccount;
using Il2CppNewtonsoft.Json.Linq;
using Euterpe.CustomAlbums.Managers;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(GameAccountSystem), "GetRanks")]
    public class GetRanksPatch
    {
        // The callback type must strictly align with the underlying Il2CppSystem.Action to prevent cross-domain invocation crashes.
        public static bool Prefix(string musicUid, int difficulty, Il2CppSystem.Action<JToken, JToken, int> callback, Il2CppSystem.Action<long, string> failCallback)
        {
            if (!musicUid.StartsWith("999"))
            {
                return true; // Let original game logic handle official charts
            }

            MelonLogger.Msg($"[Euterpe] Intercepted leaderboard request for custom chart: UID={musicUid}, Diff={difficulty}");

            try
            {
                // Retrieve the chart MD5 from CustomAlbums framework
                var album = AlbumManager.GetByUid(musicUid);
                if (album != null)
                {
                    string md5 = album.Sheets[difficulty].Md5;
                    MelonLogger.Msg($"[Euterpe] Current chart MD5: {md5}, requesting server...");
                }

                // TODO: 1. Initiate GET request to your remote server here
                // Web.Get(api_url + "?md5=" + md5, ...)
                
                string dummyJsonArray = @"[
                    {
                        ""play"": { ""score"": 999999, ""acc"": 100, ""combo"": 9999, ""character_uid"": ""0"", ""elfin_uid"": ""0"" },
                        ""user"": { ""nickname"": ""Euterpe"" }
                    }
                ]";
                string dummyJsonObject = @"{}"; // Current player's ranking object can be left empty
                
                var jarray = JArray.Parse(dummyJsonArray);
                var jobject = JObject.Parse(dummyJsonObject);
                
                // Execute callback to render the data into the game UI leaderboard
                callback.Invoke(jarray, jobject, 0); 
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Euterpe] Failed to fetch leaderboard: {ex.Message}");
                failCallback.Invoke(404L, "");
            }

            return false; // Interception complete, block original logic and other patches
        }
    }
}

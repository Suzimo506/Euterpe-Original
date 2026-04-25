using System.IO;
using System.Linq;
using HarmonyLib;
using Il2Cpp;
using Il2CppFormulaBase;
using Il2CppGameLogic;
using UnityEngine;
using Euterpe.Cinema;
using Euterpe.CustomAlbums.Managers;

namespace Euterpe.Patches
{
    [HarmonyPatch(typeof(GameMusicScene), nameof(GameMusicScene.SceneFestival))]
    internal class CinemaChristmasPatch
    {
        private static void Postfix(string __result)
        {
            if (__result.EndsWith("christmas"))
                CinemaManager.Christmas = true;
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "Exit")]
    internal class CinemaExitPatch
    {
        private static void Prefix()
        {
            DriftCorrector.Stop();

            if (CinemaManager.Player != null && CinemaManager.Player.gameObject != null)
            {
                CinemaManager.Player.gameObject.SetActive(false);
                CinemaManager.Player = null;
            }
            CinemaManager.GameStarted = false;
            CinemaManager.Christmas = false;
            
            // Restore main camera flags just in case
            if (Camera.main != null)
            {
                Camera.main.clearFlags = CameraClearFlags.Skybox;
            }
        }
    }

    [HarmonyPatch(typeof(FeverEffectManager), "ActivateFever")]
    internal class CinemaFeverPatch
    {
        private static void Postfix(Component __instance)
        {
            if (CinemaManager.Player == null) return;

            var bg = __instance.transform.Find("bg");
            if (bg != null)
            {
                var bg_S = bg.Find("bg_S");
                if (bg_S != null) bg_S.gameObject.SetActive(false);
            }
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "GameStart")]
    internal class CinemaGameStartPatch
    {
        private static void Postfix()
        {
            if (CinemaManager.Player == null) return;

            CinemaManager.GameStarted = true;
            CinemaManager.Player.Play();
            DriftCorrector.Run();
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "Load")]
    internal static class CinemaLoadStagePatch
    {
        internal static string LastMusicUid = "";

        private static void Postfix()
        {
            var musicUid = Il2CppAssets.Scripts.Database.GlobalDataBase.s_DbBattleStage.musicUid;
            if (!musicUid.StartsWith("999")) return;

            var currentAlbum = AlbumManager.LoadedAlbums.Values.SingleOrDefault(a => a.Index.ToString() == musicUid.Remove(0, 4));
            if (currentAlbum == null) return;

            var cinemaInfo = new CinemaInfo(currentAlbum);
            if (!cinemaInfo.Enabled) return;

            if (LastMusicUid != musicUid)
            {
                var videoBytes = cinemaInfo.GetVideo();
                if (videoBytes != null)
                {
                    File.WriteAllBytes(Application.dataPath + "/cinema.mp4", videoBytes);
                }
                LastMusicUid = musicUid;
            }

            CinemaManager.InitCamera(cinemaInfo.Opacity);
            CinemaManager.HideSceneElements();
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "Pause")]
    internal class CinemaPausePatch
    {
        private static void Postfix()
        {
            if (CinemaManager.Player == null) return;
            CinemaManager.Player.Pause();
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "GameRestart")]
    internal class CinemaRestartPatch
    {
        private static void Postfix()
        {
            if (CinemaManager.Player == null) return;
            CinemaManager.GameStarted = false;
            DriftCorrector.Stop();
        }
    }

    [HarmonyPatch(typeof(StageBattleComponent), "Resume")]
    internal class CinemaResumePatch
    {
        private static void Postfix()
        {
            if (CinemaManager.Player == null) return;
            if (!CinemaManager.GameStarted) return;

            CinemaManager.Player.Play();
        }
    }

    [HarmonyPatch(typeof(SceneChangeController), "OnControllerStart")]
    internal class CinemaSceneChangePatch
    {
        private static void Postfix()
        {
            if (CinemaManager.Player == null) return;
            CinemaManager.HideSceneElements();
        }
    }
}

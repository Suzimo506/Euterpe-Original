using System.IO;
using System.Linq;
using Il2Cpp;
using Il2CppAssets.Scripts.PeroTools.Commons;
using UnityEngine;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Euterpe.Managers
{
    internal static class CinemaManager
    {
        internal static bool GameStarted;
        internal static VideoPlayer Player;
        internal static GameObject CinemaObject;
        internal static bool Christmas;

        internal static void Init()
        {
            // Clean up old file from v1.1.x and below
            if (File.Exists(Application.persistentDataPath + "/cinema.mp4"))
                File.Delete(Application.persistentDataPath + "/cinema.mp4");

            if (File.Exists(Application.dataPath + "/cinema.mp4"))
                File.Delete(Application.dataPath + "/cinema.mp4");
        }

        internal static void Clear()
        {
            DriftCorrector.Stop();
            
            if (Player != null)
            {
                try { Player.Stop(); } catch { /* Ignore */ }
                Player = null;
            }

            if (CinemaObject != null)
            {
                Object.Destroy(CinemaObject);
                CinemaObject = null;
            }

            GameStarted = false;
            Christmas = false;
        }

        internal static void Cleanup()
        {
            Clear();
            if (File.Exists(Application.dataPath + "/cinema.mp4"))
                File.Delete(Application.dataPath + "/cinema.mp4");
        }

        internal static void InitCamera(float opacity)
        {
            Clear();

            var camera = Camera.allCameras.Single(c => c.name == "Camera_3D");

            // Create new cinema camera
            var videoCamera = Object.Instantiate(camera);
            CinemaObject = videoCamera.gameObject;
            videoCamera.name = "Camera_Cinema";
            videoCamera.depth = -2;
            videoCamera.transform.position = new Vector3(0, 0, -9001);
            videoCamera.clearFlags = CameraClearFlags.SolidColor;
            videoCamera.orthographic = true;
            videoCamera.orthographicSize = Camera.main.orthographicSize;
            videoCamera.cullingMask = -1;
            videoCamera.backgroundColor = Color.black;
            Camera.main.clearFlags = CameraClearFlags.Depth;

            // Add video player to new camera
            Player = CinemaObject.AddComponent<VideoPlayer>();
            Player.playOnAwake = false;
            Player.targetCameraAlpha = opacity;
            Player.audioOutputMode = VideoAudioOutputMode.None;
            Player.aspectRatio = VideoAspectRatio.FitOutside;
            Player.url = Application.dataPath + "/cinema.mp4";
            Player.skipOnDrop = true;
            Player.Prepare();
        }

        internal static void HideSceneElements()
        {
            var sceneName = SceneChangeController.curScene > 9
                ? $"scene_{SceneChangeController.curScene}"
                : $"scene_0{SceneChangeController.curScene}";
            if (Christmas && sceneName == "scene_05") sceneName += "_christmas";

            var sceneObject = GameObject.Find("SceneObjectController")?.transform.Find(sceneName);
            if (sceneObject == null) return;

            if (SingletonMonoBehaviour<GameSceneContainer>.instance?.sprLightness != null)
            {
                SingletonMonoBehaviour<GameSceneContainer>.instance.sprLightness.color = new Color(0, 0, 0, 0);
            }

            for (var i = 0; i < sceneObject.childCount; i++)
                sceneObject.GetChild(i).gameObject.SetActive(false);

            sceneObject.gameObject.SetActive(false);
        }
    }
}

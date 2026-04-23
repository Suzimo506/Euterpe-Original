using System.Collections.Concurrent;
using Euterpe.CustomAlbums.Data;
using Euterpe.CustomAlbums.Patches;
using Euterpe.CustomAlbums.Utilities;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Database;
using Il2CppAssets.Scripts.Database.DataClass;
using Il2CppAssets.Scripts.PeroTools.Commons;
using Il2CppAssets.Scripts.PeroTools.Managers;
using Il2CppAssets.Scripts.UI.Panels;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppPeroTools2.Resources;
using static Il2CppAssets.Scripts.Database.DBConfigCustomTags;

namespace Euterpe.CustomAlbums.Managers
{
    internal static class HotReloadManager
    {
        private static readonly Logger Logger = new(nameof(HotReloadManager));

        // Thread-safe queues for FileSystemWatcher background events
        private static ConcurrentQueue<string> AlbumsToAdd { get; } = new();
        private static ConcurrentQueue<string> AlbumsToDelete { get; } = new();
        private static PnlStage PnlStageInstance { get; set; }

        // Hot-loaded MusicInfo cache: uid -> MusicInfo
        // Used by GetMusicInfoFromAll Harmony Postfix
        private static readonly Dictionary<string, MusicInfo> HotLoadedMusicInfos = new();
        private static readonly Dictionary<string, LocalALBUMInfo> HotLoadedLocalAlbumInfos = new();

        /// <summary>
        ///     Checks if a file is fully written and no longer locked by other processes.
        /// </summary>
        private static bool IsFileUnlocked(string path)
        {
            try
            {
                using var fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
                return fileStream.Length > 0;
            }
            catch (Exception ex) when (ex is FileNotFoundException or IOException)
            {
                return false;
            }
        }

        /// <summary>
        ///     Creates a MusicInfo object from an Album with all fields populated.
        /// </summary>
        private static MusicInfo CreateMusicInfo(Album album)
        {
            var albumInfo = album.Info;
            var albumName = album.AlbumName;
            var uid = $"{AlbumManager.Uid}-{album.Index}";

            var musicInfo = new MusicInfo
            {
                uid = uid,
                name = albumInfo.Name ?? "",
                author = albumInfo.Author ?? "",
                bpm = albumInfo.Bpm ?? "0",
                music = $"{albumName}_music",
                demo = $"{albumName}_demo",
                cover = $"{albumName}_cover",
                noteJson = $"{albumName}_map",
                scene = albumInfo.Scene ?? "scene_01",
                hexieCover = $"{albumName}_cover",
                unlockLevel = 0,
                newMusic = false,
                levelDesigner = albumInfo.LevelDesigner ?? "",
                levelDesigner1 = albumInfo.LevelDesigner1 ?? albumInfo.LevelDesigner ?? "",
                levelDesigner2 = albumInfo.LevelDesigner2 ?? albumInfo.LevelDesigner ?? "",
                levelDesigner3 = albumInfo.LevelDesigner3 ?? albumInfo.LevelDesigner ?? "",
                levelDesigner4 = albumInfo.LevelDesigner4 ?? albumInfo.LevelDesigner ?? "",
                levelDesigner5 = albumInfo.LevelDesigner5 ?? albumInfo.LevelDesigner ?? "",
                difficulty1 = albumInfo.Difficulty1 ?? "0",
                difficulty2 = albumInfo.Difficulty2 ?? "0",
                difficulty3 = albumInfo.Difficulty3 ?? "0",
                difficulty4 = albumInfo.Difficulty4 ?? "0",
                difficulty5 = albumInfo.Difficulty5 ?? "0"
            };

            musicInfo.callBackDifficulty1 = ParseDifficulty(albumInfo.Difficulty1);
            musicInfo.callBackDifficulty2 = ParseDifficulty(albumInfo.Difficulty2);
            musicInfo.callBackDifficulty3 = ParseDifficulty(albumInfo.Difficulty3);
            musicInfo.callBackDifficulty4 = ParseDifficulty(albumInfo.Difficulty4);
            musicInfo.callBackDifficulty5 = ParseDifficulty(albumInfo.Difficulty5);

            // new MusicInfo() alone is not enough for runtime UI use.
            // The normal game load path also initializes internal/localized state.
            musicInfo.Init(album.Index);
            musicInfo.InitExInfo();
            musicInfo.m_MusicExInfo = CreateMusicExInfo(album);

            return musicInfo;
        }

        private static LocalALBUMInfo CreateLocalAlbumInfo(Album album)
        {
            var albumInfo = album.Info;
            return new LocalALBUMInfo
            {
                name = albumInfo.Name ?? string.Empty,
                author = albumInfo.Author ?? string.Empty
            };
        }

        private static int ParseDifficulty(string difficulty)
        {
            return int.TryParse(difficulty, out var value) ? value : 0;
        }

        private static MusicExInfo CreateMusicExInfo(Album album)
        {
            var albumInfo = album.Info;
            var changedDiff = new Il2CppStructArray<int>(5);
            changedDiff[0] = ParseDifficulty(albumInfo.Difficulty1);
            changedDiff[1] = ParseDifficulty(albumInfo.Difficulty2);
            changedDiff[2] = ParseDifficulty(albumInfo.Difficulty3);
            changedDiff[3] = ParseDifficulty(albumInfo.Difficulty4);
            changedDiff[4] = ParseDifficulty(albumInfo.Difficulty5);

            var musicExInfo = Interop.CreateTypeValue<MusicExInfo>();
            musicExInfo.m_AlbumIndex = AlbumManager.Uid + 1;
            musicExInfo.m_AlbumUidIndex = AlbumManager.Uid;
            musicExInfo.m_MusicIndex = album.Index;
            musicExInfo.m_AlbumUidName = AlbumManager.MusicPackage;
            musicExInfo.m_AlbumJsonName = AlbumManager.JsonName;
            musicExInfo.m_ChangedDiff = changedDiff;
            return musicExInfo;
        }

        /// <summary>
        ///     Hot-add: Injects a new .mdm file into the game's runtime database.
        /// </summary>
        private static void ProcessAdditions()
        {
            var addedAny = false;

            while (AlbumsToAdd.TryDequeue(out var path))
            {
                try
                {
                    // 1. Load album into AlbumManager
                    var album = AlbumManager.LoadOne(path);
                    if (album == null)
                    {
                        Logger.Warning($"HotReload: Failed to load album from {path}");
                        continue;
                    }

                    var albumName = album.AlbumName;
                    var uid = $"{AlbumManager.Uid}-{album.Index}";
                    var albumInfo = album.Info;
                    Logger.Msg($"HotReload: Adding {albumName} (UID: {uid})", false);

                    // 2. Create MusicInfo and register to hot-load cache
                    var musicInfo = CreateMusicInfo(album);
                    var localAlbumInfo = CreateLocalAlbumInfo(album);
                    HotLoadedMusicInfos[uid] = musicInfo;
                    HotLoadedLocalAlbumInfos[uid] = localAlbumInfo;
                    Logger.Msg($"HotReload: Created MusicInfo for {uid}", false);

                    // 3. Inject search tags into ConfigManager
                    try
                    {
                        var config = Singleton<ConfigManager>.instance.GetConfigObject<DBConfigMusicSearchTag>();
                        var searchTag = new MusicSearchTagInfo
                        {
                            uid = uid,
                            listIndex = config.count
                        };

                        var tags = new List<string> { "custom albums" };
                        if (albumInfo.SearchTags != null) tags.AddRange(albumInfo.SearchTags);
                        if (!string.IsNullOrEmpty(albumInfo.NameRomanized)) tags.Add(albumInfo.NameRomanized);
                        for (var i = 0; i < tags.Count; i++) tags[i] = tags[i].ToLower();
                        searchTag.tag = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(tags.ToArray());

                        if (!config.m_Dictionary.ContainsKey(uid))
                        {
                            config.m_Dictionary.Add(uid, searchTag);
                            config.list.Add(searchTag);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Warning($"HotReload: Failed to add search tags: {ex.Message}");
                    }

                    // 4. Preload cover resources
                    try
                    {
                        if (album.HasFile("cover.png") || album.HasFile("cover.gif"))
                        {
                            ResourcesManager.instance
                                .LoadFromName<UnityEngine.Sprite>($"{albumName}_cover")
                                .hideFlags |= UnityEngine.HideFlags.DontUnloadUnusedAsset;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Warning($"HotReload: Failed to preload cover: {ex.Message}");
                    }

                    addedAny = true;
                    Logger.Msg($"HotReload: Successfully added {albumInfo.Name}", false);
                }
                catch (Exception ex)
                {
                    Logger.Warning($"HotReload: Error adding album: {ex.Message}");
                    Logger.Warning(ex.StackTrace);
                }
            }

            if (addedAny)
            {
                // Rebuild tags (update UID list) and refresh UI
                RebuildCustomAlbumsTag();
                RefreshUI();
            }
        }

        /// <summary>
        ///     Hot-delete: Removes a specified album from the game's runtime database.
        /// </summary>
        private static void ProcessDeletions()
        {
            var deletedAny = false;

            while (AlbumsToDelete.TryDequeue(out var albumFileName))
            {
                try
                {
                    var albumKey = $"album_{albumFileName}";
                    Logger.Msg($"HotReload: Removing {albumKey}", false);

                    if (!AlbumManager.LoadedAlbums.TryGetValue(albumKey, out var album))
                    {
                        Logger.Warning($"HotReload: Album {albumKey} not found");
                        continue;
                    }

                    var uid = $"{AlbumManager.Uid}-{album.Index}";

                    // Remove from hot-load cache
                    HotLoadedMusicInfos.Remove(uid);
                    HotLoadedLocalAlbumInfos.Remove(uid);

                    // Remove from game music database
                    try
                    {
                        var musicInfo = GlobalDataBase.s_DbMusicTag.GetMusicInfoFromAll(uid);
                        if (musicInfo != null)
                            GlobalDataBase.s_DbMusicTag.RemoveShowMusicUid(musicInfo);
                    }
                    catch (Exception ex)
                    {
                        Logger.Warning($"HotReload: Failed to remove from DB: {ex.Message}");
                    }

                    // Clear resource cache
                    AlbumManager.LoadedAlbums.Remove(albumKey);
                    CoverManager.CachedAnimatedCovers.Remove(album.Index);
                    CoverManager.CachedCovers.Remove(album.Index);
                    AssetPatch.RemoveFromCache($"{albumKey}_demo");
                    AssetPatch.RemoveFromCache($"{albumKey}_music");
                    AssetPatch.RemoveFromCache($"{albumKey}_cover");

                    deletedAny = true;
                    Logger.Msg($"HotReload: Removed {albumKey}", false);
                }
                catch (Exception ex)
                {
                    Logger.Warning($"HotReload: Error removing: {ex.Message}");
                    Logger.Warning(ex.StackTrace);
                }
            }

            if (deletedAny)
            {
                RebuildCustomAlbumsTag();
                RefreshUI();
            }
        }

        /// <summary>
        ///     Rebuild Custom Albums tag to update the UID list.
        /// </summary>
        private static void RebuildCustomAlbumsTag()
        {
            try
            {
                var customInfo = new CustomTagInfo
                {
                    tag_name = AlbumManager.Languages.ToIl2Cpp(),
                    tag_picture = "https://cdn.mdmc.moe/static/melon.png",
                    music_list = AlbumManager.GetAllUid().ToIl2Cpp()
                };

                var existingTag = GlobalDataBase.dbMusicTag.GetAlbumTagInfo(AlbumManager.Uid);
                if (existingTag != null)
                {
                    existingTag.InitCustomTagInfo(customInfo);
                    Logger.Msg($"HotReload: Tag updated ({AlbumManager.LoadedAlbums.Count} albums)", false);
                }
            }
            catch (Exception ex)
            {
                Logger.Warning($"HotReload: Tag rebuild failed: {ex.Message}");
            }
        }

        /// <summary>
        ///     Refresh the song selection UI.
        /// </summary>
        private static void RefreshUI()
        {
            if (PnlStageInstance == null) return;

            try
            {
                PnlStageInstance.m_MusicRootAnimator?.Play(PnlStageInstance.animNameAlbumIn);
                PnlStageInstance.RefreshMusicFSV();
                Logger.Msg("HotReload: UI refreshed", false);
            }
            catch (Exception ex)
            {
                Logger.Warning($"HotReload: UI refresh failed: {ex.Message}");
            }
        }

        /// <summary>
        ///     Consume the queue in Unity's FixedUpdate (main thread safe).
        /// </summary>
        internal static void FixedUpdate()
        {
            if (AlbumsToAdd.IsEmpty && AlbumsToDelete.IsEmpty) return;

            if (PnlStageInstance == null) return;

            Logger.Msg($"HotReload: Processing queue (add={AlbumsToAdd.Count}, del={AlbumsToDelete.Count})", false);
            ProcessAdditions();
            ProcessDeletions();
        }

        /// <summary>
        ///     Initialize FileSystemWatcher to monitor Custom_Albums directory changes.
        /// </summary>
        internal static void OnLateInitializeMelon()
        {
            try
            {
                var watchPath = Path.GetFullPath(AlbumManager.SearchPath);
                Logger.Msg($"HotReload: Watching directory: {watchPath}", false);

                if (!Directory.Exists(watchPath))
                {
                    Logger.Warning($"HotReload: Directory does not exist: {watchPath}");
                    return;
                }

                AlbumManager.AlbumWatcher.Path = watchPath;
                AlbumManager.AlbumWatcher.Filter = AlbumManager.SearchPattern;

                AlbumManager.AlbumWatcher.Created += (_, e) =>
                {
                    Logger.Msg($"HotReload: Detected new file: {e.Name}", false);
                    Task.Run(() =>
                    {
                        var attempts = 0;
                        while (!IsFileUnlocked(e.FullPath) && attempts < 50)
                        {
                            Thread.Sleep(200);
                            attempts++;
                        }

                        if (attempts < 50)
                        {
                            AlbumsToAdd.Enqueue(e.FullPath);
                            Logger.Msg($"HotReload: Queued for addition: {e.Name}", false);
                        }
                        else
                        {
                            Logger.Warning($"HotReload: Timed out waiting for file: {e.Name}");
                        }
                    });
                };

                AlbumManager.AlbumWatcher.Deleted += (_, e) =>
                {
                    Logger.Msg($"HotReload: Detected deletion: {e.Name}", false);
                    AlbumsToDelete.Enqueue(Path.GetFileNameWithoutExtension(e.Name));
                };

                AlbumManager.AlbumWatcher.Renamed += (_, e) =>
                {
                    Logger.Msg($"HotReload: Detected rename: {e.OldName} -> {e.Name}", false);
                    var oldKey = $"album_{Path.GetFileNameWithoutExtension(e.OldName)}";
                    var newKey = $"album_{Path.GetFileNameWithoutExtension(e.Name)}";

                    if (AlbumManager.LoadedAlbums.Remove(oldKey, out var album))
                    {
                        AlbumManager.LoadedAlbums.TryAdd(newKey, album);
                        AssetPatch.ModifyCacheKey($"{oldKey}_demo", $"{newKey}_demo");
                        AssetPatch.ModifyCacheKey($"{oldKey}_music", $"{newKey}_music");
                        AssetPatch.ModifyCacheKey($"{oldKey}_cover", $"{newKey}_cover");
                        Logger.Msg($"HotReload: Renamed {oldKey} -> {newKey}", false);
                    }
                };

                AlbumManager.AlbumWatcher.EnableRaisingEvents = true;
                Logger.Msg("HotReload: FileSystemWatcher initialized!", false);
            }
            catch (Exception ex)
            {
                Logger.Warning($"HotReload: Init failed: {ex.Message}");
                Logger.Warning(ex.StackTrace);
            }
        }

        // ============================================================
        // Harmony Patches
        // ============================================================

        /// <summary>
        ///     Intercepts GetMusicInfoFromAll: Returns our manually created MusicInfo
        ///     when the game looks up a hot-loaded song.
        /// </summary>
        // TODO: HotReload temporarily disabled
        // [HarmonyPatch(typeof(DBMusicTag), nameof(DBMusicTag.GetMusicInfoFromAll))]
        internal static class GetMusicInfoFromAllPatch
        {
            private static void Postfix(string musicUid, ref MusicInfo __result)
            {
                // Intervene only if the game failed to find MusicInfo
                if (__result != null) return;

                if (HotLoadedMusicInfos.TryGetValue(musicUid, out var hotMusicInfo))
                {
                    __result = hotMusicInfo;
                }
            }
        }

        // TODO: HotReload temporarily disabled
        // [HarmonyPatch(typeof(MusicInfo), nameof(MusicInfo.GetLocal))]
        internal static class GetLocalPatch
        {
            private static void Postfix(MusicInfo __instance, int language, ref LocalALBUMInfo __result)
            {
                if (__result != null || __instance == null || string.IsNullOrEmpty(__instance.uid)) return;

                if (HotLoadedLocalAlbumInfos.TryGetValue(__instance.uid, out var localAlbumInfo))
                {
                    __result = localAlbumInfo;
                }
            }
        }

        /// <summary>
        ///     Capture PnlStage instance reference.
        /// </summary>
        // TODO: HotReload temporarily disabled
        // [HarmonyPatch(typeof(PnlStage), nameof(PnlStage.PreWarm))]
        internal static class StagePreWarmPatch
        {
            private static void Postfix(PnlStage __instance)
            {
                PnlStageInstance = __instance;
            }
        }
    }
}

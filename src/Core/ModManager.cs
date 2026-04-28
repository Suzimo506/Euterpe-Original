using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Il2CppUI.Controls; 
using Il2CppAssets.Scripts.UI.Panels; 
using Il2CppArcadeController.UI.Panel.PnlHome;
using Il2CppInterop.Runtime;
using HarmonyLib;
using UnityEngine.Networking;
using System.Collections;
using Euterpe.CustomAlbums;
using Euterpe.CustomAlbums.Managers;
using Euterpe.CustomAlbums.Patches;
using Euterpe.Managers;
using static Euterpe.CustomAlbums.Patches.AnimatedCoverPatch;

namespace Euterpe.Core
{
    public class ModManager : MelonMod
    {
        // ----- Local Preferences Configuration -----
        private static MelonPreferences_Category _configCategory;
        public static MelonPreferences_Entry<bool> EnableUpdatePopup;

        private static System.Action _onConfirmAction;
        private static System.Action _onCancelAction;
        private static Il2CppSystem.Action _il2cppConfirm;
        private static Il2CppSystem.Action _il2cppCancel;

        // Global UI mutex lock. Activates interceptors to block native popup requests while the update prompt is active.
        public static bool IsPopupLockActive = false;

        // Ensures update checks only execute exactly once per session lifecycle.
        internal bool _hasCheckedUpdate = false;

        // Static singleton instance for interceptor callbacks
        public static ModManager Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            Instance = this;
            LoggerInstance.Msg("Euterpe Auto-Updater Core System Initialized!");

            // Persist configuration via MelonLoader standards.
            _configCategory = MelonPreferences.CreateCategory("Euterpe");
            EnableUpdatePopup = _configCategory.CreateEntry<bool>("EnableAutoUpdateCheck", true);

            // ===== CustomAlbums Initialization Pipeline =====
            if (!Directory.Exists(AlbumManager.SearchPath)) Directory.CreateDirectory(AlbumManager.SearchPath);
            ModSettings.Register();
            AssetPatch.AttachHook();
            SavePatch.AttachHook();
            AlbumManager.LoadAlbums();
            SaveManager.LoadSaveFile();
            LoggerInstance.Msg("Initialized CustomAlbums!");
            // ===== CustomAlbums Initialization Complete =====

            // Initialize Cinema
            CinemaManager.Init();

            // Confirm Callback: Invokes external updater and aborts current game process.
            _onConfirmAction = new System.Action(() =>
            {
                IsPopupLockActive = false; // Release intercept lock
                LoggerInstance.Msg("============ [ Euterpe Interaction ] ============");
                LoggerInstance.Msg("-> User Action: Action [CONFIRM] dispatched successfully.");
                LoggerInstance.Msg("-> Result: Launching Euterpe Updater DeepLink protocol & Terminating current Game Process.");
                LoggerInstance.Msg("=================================================");
                Application.OpenURL("Euterpe://go/modding/manage");
                Application.Quit();
            });

            // Cancel Callback: Dismisses intercept lock and resumes game.
            _onCancelAction = new System.Action(() =>
            {
                IsPopupLockActive = false; // Release intercept lock
                LoggerInstance.Msg("============ [ Euterpe Interaction ] ============");
                LoggerInstance.Msg("-> User Action: Action [CANCEL] or Panel Dismissed by user.");
                LoggerInstance.Msg("-> Result: Alert Panel Terminated. Resuming main thread logic.");
                LoggerInstance.Msg("=================================================");
            });

            _il2cppConfirm = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(_onConfirmAction);
            _il2cppCancel = DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(_onCancelAction);

            // Start background page detection coroutine
            MelonCoroutines.Start(WaitForHomePage());
        }

        public override void OnLateInitializeMelon()
        {
            // Post-initialization hooks after all mods have loaded
            Headquarters.Init();

            // TODO: HotReload temporarily disabled until UI interaction issues are fully resolved.
            /*
            // Start HotReload file system watcher
            try
            {
                LoggerInstance.Msg("Starting HotReload initialization...");
                HotReloadManager.OnLateInitializeMelon();
            }
            catch (Exception ex)
            {
                LoggerInstance.Error($"HotReload init failed: {ex.Message}");
                LoggerInstance.Error(ex.StackTrace);
            }
            */
        }

        public override void OnFixedUpdate()
        {
            // CustomAlbums: Process HotReload queue (Triggered only in song selection screen)
            // TODO: HotReload temporarily disabled
            // HotReloadManager.FixedUpdate();
        }

        public override void OnLateUpdate()
        {
            // Sync background video player with game time
            DriftCorrector.LateUpdate();
        }

        public override void OnDeinitializeMelon()
        {
            base.OnDeinitializeMelon();
            CinemaManager.Cleanup();
        }

        public override void OnUpdate()
        {
            // CustomAlbums: Drive animated cover frame updates
            MusicStageCellPatch.AnimateCoversUpdate();

            // Focus redirection patch for popups
            if (IsPopupLockActive && CommonMessageBox.s_Instance != null)
            {
                // Trigger Confirm button
                if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    if (CommonMessageBox.s_Instance.m_BtnLayoutRects.Length > 0)
                    {
                        var confirmBtn = CommonMessageBox.s_Instance.m_BtnLayoutRects[0].GetComponent<UnityEngine.UI.Button>();
                        if (confirmBtn != null) confirmBtn.onClick.Invoke();
                    }
                }
                // Trigger Cancel button
                else if (Input.GetKeyDown(KeyCode.Escape))
                {
                    if (CommonMessageBox.s_Instance.m_BtnLayoutRects.Length > 1)
                    {
                        var cancelBtn = CommonMessageBox.s_Instance.m_BtnLayoutRects[1].GetComponent<UnityEngine.UI.Button>();
                        if (cancelBtn != null) cancelBtn.onClick.Invoke();
                    }
                }
            }
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
            // CustomAlbums: Track active scene for animated cover states
            MusicStageCellPatch.CurrentScene = sceneName;
        }

        // Trigger version verification sequence
        internal void VerifyVersionsTrigger()
        {
            // Start asynchronous coroutine to decouple network requests from the main render thread
            MelonCoroutines.Start(FetchApiCoroutine());
        }

        private IEnumerator FetchApiCoroutine()
        {
            LoggerInstance.Msg("=========== Euterpe Scanner Started ===========");

            var installedMods = new System.Collections.Generic.Dictionary<string, string>();

            // Inject the auto-updater module as a mandatory target
            installedMods[this.Info.Name] = this.Info.Version;
            LoggerInstance.Msg($"[+] {this.Info.Name} (v{this.Info.Version})");

            // Extract installed versions from registered mods in the runtime pool
            foreach (var mod in MelonMod.RegisteredMelons)
            {
                if (!installedMods.ContainsKey(mod.Info.Name))
                {
                    installedMods.Add(mod.Info.Name, mod.Info.Version);
                    LoggerInstance.Msg($"[+] {mod.Info.Name} (v{mod.Info.Version})");
                }
            }

            // Remote API endpoint
            string apiUrl = "https://Euterpe.example.com/api/v1/update"; // TODO: Replace with the actual remote configuration URL
            LoggerInstance.Msg($"[+] Dispatching Async Request to: {apiUrl}");

            // Initiate asynchronous HTTP GET request
            var request = UnityWebRequest.Get(apiUrl);
            yield return request.SendWebRequest();

            bool requiresUpdate = false;

            if (!request.isNetworkError && !request.isHttpError)
            {
                // TODO: Implement API payload parsing logic
                LoggerInstance.Msg("-> Payload retrieved successfully. Parsing API parameters...");
            }
            else
            {
                LoggerInstance.Error($"API Request Failed: {request.error}");
            }

            // Force trigger update popup for testing
            requiresUpdate = true; 

            LoggerInstance.Msg("=========== Euterpe Scanner Completed ===========");

            if (requiresUpdate)
            {
                // Initialize i18n (detects game language automatically)
                I18n.Initialize();
                
                string msgBuilder = I18n.Get("update.available");

                CommonMessageBox.ShowConfrimAndCancelWithShut(msgBuilder, _il2cppConfirm, _il2cppCancel);

                // Establish sole UI focus via intercept lock
                IsPopupLockActive = true; 
            }
        }

        // Wait for Home Page initialization via coroutine polling
        private IEnumerator WaitForHomePage()
        {
            while (!_hasCheckedUpdate)
            {
                // Abort polling if auto-updates are disabled via config
                if (!EnableUpdatePopup.Value)
                {
                    _hasCheckedUpdate = true;
                    yield break; 
                }

                var homePage = UnityEngine.Object.FindObjectOfType<PageHome>();
                if (homePage != null && homePage.gameObject.activeInHierarchy)
                {
                    _hasCheckedUpdate = true;
                    VerifyVersionsTrigger();
                    yield break;
                }
                
                // Delay next check by 1 second while waiting for Home Page
                yield return new WaitForSeconds(1f);
            }
        }
    }

    // ================== Sub-System Interceptor Directives ==================
    
    // Intercept native dialogue box with shutdown request
    [HarmonyPatch(typeof(CommonMessageBox), nameof(CommonMessageBox.ShowConfrimAndCancelWithShut))]
    public class InterceptMessageBox_WithShut
    {
        public static bool Prefix()
        {
            // Abort native execution flow if the intercept lock is active
            return !ModManager.IsPopupLockActive; 
        }
    }

    // Intercept standard native dialogue box
    [HarmonyPatch(typeof(CommonMessageBox), nameof(CommonMessageBox.ShowConfrimAndCancel))]
    public class InterceptMessageBox_Normal
    {
        public static bool Prefix()
        {
            return !ModManager.IsPopupLockActive;
        }
    }
}
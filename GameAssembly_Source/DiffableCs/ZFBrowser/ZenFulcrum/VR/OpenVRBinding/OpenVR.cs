namespace ZenFulcrum.VR.OpenVRBinding;

public class OpenVR
{
	private class COpenVRContext
	{
		private CVRSystem m_pVRSystem; //Field offset: 0x10
		private CVRChaperone m_pVRChaperone; //Field offset: 0x18
		private CVRChaperoneSetup m_pVRChaperoneSetup; //Field offset: 0x20
		private CVRCompositor m_pVRCompositor; //Field offset: 0x28
		private CVROverlay m_pVROverlay; //Field offset: 0x30
		private CVRRenderModels m_pVRRenderModels; //Field offset: 0x38
		private CVRExtendedDisplay m_pVRExtendedDisplay; //Field offset: 0x40
		private CVRSettings m_pVRSettings; //Field offset: 0x48
		private CVRApplications m_pVRApplications; //Field offset: 0x50
		private CVRScreenshots m_pVRScreenshots; //Field offset: 0x58
		private CVRTrackedCamera m_pVRTrackedCamera; //Field offset: 0x60
		private CVRInput m_pVRInput; //Field offset: 0x68
		private CVRSpatialAnchors m_pVRSpatialAnchors; //Field offset: 0x70

		public COpenVRContext() { }

		private void CheckClear() { }

		public void Clear() { }

		public CVRApplications VRApplications() { }

		public CVRChaperone VRChaperone() { }

		public CVRChaperoneSetup VRChaperoneSetup() { }

		public CVRCompositor VRCompositor() { }

		public CVRExtendedDisplay VRExtendedDisplay() { }

		public CVRInput VRInput() { }

		public CVROverlay VROverlay() { }

		public CVRRenderModels VRRenderModels() { }

		public CVRScreenshots VRScreenshots() { }

		public CVRSettings VRSettings() { }

		public CVRSpatialAnchors VRSpatialAnchors() { }

		public CVRSystem VRSystem() { }

		public CVRTrackedCamera VRTrackedCamera() { }

	}

	public const uint k_nDriverNone = 4294967295; //Field offset: 0x0
	public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb"; //Field offset: 0x0
	public const string k_pch_Keyboard_Section = "keyboard"; //Field offset: 0x0
	public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions"; //Field offset: 0x0
	public const string k_pch_Keyboard_ScaleX = "ScaleX"; //Field offset: 0x0
	public const string k_pch_Keyboard_ScaleY = "ScaleY"; //Field offset: 0x0
	public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX"; //Field offset: 0x0
	public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX"; //Field offset: 0x0
	public const string k_pch_Keyboard_OffsetY = "OffsetY"; //Field offset: 0x0
	public const string k_pch_Keyboard_Smoothing = "Smoothing"; //Field offset: 0x0
	public const string k_pch_Perf_Section = "perfcheck"; //Field offset: 0x0
	public const string k_pch_Perf_PerfGraphInHMD_Bool = "perfGraphInHMD"; //Field offset: 0x0
	public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore"; //Field offset: 0x0
	public const string k_pch_Notifications_Section = "notifications"; //Field offset: 0x0
	public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit"; //Field offset: 0x0
	public const string k_pch_Perf_LinuxGPUProfiling_Bool = "linuxGPUProfiling"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_Section = "collisionBounds"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB"; //Field offset: 0x0
	public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA"; //Field offset: 0x0
	public const string k_pch_Camera_Section = "camera"; //Field offset: 0x0
	public const string k_pch_Perf_TestData_Float = "perfTestData"; //Field offset: 0x0
	public const string k_pch_Camera_EnableCamera_Bool = "enableCamera"; //Field offset: 0x0
	public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType"; //Field offset: 0x0
	public const string k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool = "HidePopupsWhenStatusMinimized"; //Field offset: 0x0
	public const string k_pch_DirectMode_EdidPid_Int32 = "edidPid"; //Field offset: 0x0
	public const string k_pch_Lighthouse_Section = "driver_lighthouse"; //Field offset: 0x0
	public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu"; //Field offset: 0x0
	public const string k_pch_Lighthouse_DisableIMUExceptHMD_Bool = "disableimuexcepthmd"; //Field offset: 0x0
	public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation"; //Field offset: 0x0
	public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug"; //Field offset: 0x0
	public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation"; //Field offset: 0x0
	public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory"; //Field offset: 0x0
	public const string k_pch_Lighthouse_EnableBluetooth_Bool = "enableBluetooth"; //Field offset: 0x0
	public const string k_pch_Lighthouse_PowerManagedBaseStations_String = "PowerManagedBaseStations"; //Field offset: 0x0
	public const string k_pch_Lighthouse_PowerManagedBaseStations2_String = "PowerManagedBaseStations2"; //Field offset: 0x0
	public const string k_pch_Lighthouse_EnableImuFallback_Bool = "enableImuFallback"; //Field offset: 0x0
	public const string k_pch_UserInterface_Screenshots_Bool = "screenshots"; //Field offset: 0x0
	public const string k_pch_Null_Section = "driver_null"; //Field offset: 0x0
	public const string k_pch_Null_ModelNumber_String = "modelNumber"; //Field offset: 0x0
	public const string k_pch_Null_WindowX_Int32 = "windowX"; //Field offset: 0x0
	public const string k_pch_Null_WindowY_Int32 = "windowY"; //Field offset: 0x0
	public const string k_pch_Null_WindowWidth_Int32 = "windowWidth"; //Field offset: 0x0
	public const string k_pch_Null_WindowHeight_Int32 = "windowHeight"; //Field offset: 0x0
	public const string k_pch_Null_RenderWidth_Int32 = "renderWidth"; //Field offset: 0x0
	public const string k_pch_Null_RenderHeight_Int32 = "renderHeight"; //Field offset: 0x0
	public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons"; //Field offset: 0x0
	public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency"; //Field offset: 0x0
	public const string k_pch_UserInterface_Section = "userinterface"; //Field offset: 0x0
	public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop"; //Field offset: 0x0
	public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray"; //Field offset: 0x0
	public const string k_pch_Null_SerialNumber_String = "serialNumber"; //Field offset: 0x0
	public const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard"; //Field offset: 0x0
	public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds"; //Field offset: 0x0
	public const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView"; //Field offset: 0x0
	public const string k_pch_VRWebHelper_Section = "VRWebHelper"; //Field offset: 0x0
	public const string k_pch_VRWebHelper_DebuggerEnabled_Bool = "DebuggerEnabled"; //Field offset: 0x0
	public const string k_pch_VRWebHelper_DebuggerPort_Int32 = "DebuggerPort"; //Field offset: 0x0
	public const string k_pch_TrackingOverride_Section = "TrackingOverrides"; //Field offset: 0x0
	public const string k_pch_App_BindingAutosaveURLSuffix_String = "AutosaveURL"; //Field offset: 0x0
	public const string k_pch_App_BindingCurrentURLSuffix_String = "CurrentURL"; //Field offset: 0x0
	public const string k_pch_App_NeedToUpdateAutosaveSuffix_Bool = "NeedToUpdateAutosave"; //Field offset: 0x0
	public const string k_pch_App_ActionManifestURL_String = "ActionManifestURL"; //Field offset: 0x0
	public const string k_pch_Trackers_Section = "trackers"; //Field offset: 0x0
	public const string k_pch_DesktopUI_Section = "DesktopUI"; //Field offset: 0x0
	public const string k_pch_LastKnown_Section = "LastKnown"; //Field offset: 0x0
	public const string k_pch_LastKnown_HMDManufacturer_String = "HMDManufacturer"; //Field offset: 0x0
	public const string k_pch_WebInterface_WebPort_String = "WebPort"; //Field offset: 0x0
	public const string k_pch_LastKnown_HMDModel_String = "HMDModel"; //Field offset: 0x0
	public const string IVRResources_Version = "IVRResources_001"; //Field offset: 0x0
	public const string IVRDriverManager_Version = "IVRDriverManager_001"; //Field offset: 0x0
	public const uint k_unMaxActionNameLength = 64; //Field offset: 0x0
	public const uint k_unMaxActionSetNameLength = 64; //Field offset: 0x0
	public const uint k_unMaxActionOriginCount = 16; //Field offset: 0x0
	public const uint k_unMaxBoneNameLength = 32; //Field offset: 0x0
	public const string IVRInput_Version = "IVRInput_005"; //Field offset: 0x0
	public const ulong k_ulInvalidIOBufferHandle = 0; //Field offset: 0x0
	public const string IVRIOBuffer_Version = "IVRIOBuffer_001"; //Field offset: 0x0
	public const uint k_ulInvalidSpatialAnchorHandle = 0; //Field offset: 0x0
	public const string IVRSpatialAnchors_Version = "IVRSpatialAnchors_001"; //Field offset: 0x0
	[CompilerGenerated]
	private static uint <VRToken>k__BackingField; //Field offset: 0x0
	public const string IVRScreenshots_Version = "IVRScreenshots_001"; //Field offset: 0x0
	public const string k_pch_WebInterface_WebEnable_Bool = "WebEnable"; //Field offset: 0x0
	public const string k_pch_WebInterface_Section = "WebInterface"; //Field offset: 0x0
	public const string k_pch_Driver_Enable_Bool = "enable"; //Field offset: 0x0
	public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR"; //Field offset: 0x0
	public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG"; //Field offset: 0x0
	public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB"; //Field offset: 0x0
	public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA"; //Field offset: 0x0
	public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength"; //Field offset: 0x0
	public const string k_pch_Camera_RoomViewMode_Int32 = "cameraRoomViewMode"; //Field offset: 0x0
	public const string k_pch_audio_Section = "audio"; //Field offset: 0x0
	public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice"; //Field offset: 0x0
	public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice"; //Field offset: 0x0
	public const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice"; //Field offset: 0x0
	public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice"; //Field offset: 0x0
	public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice"; //Field offset: 0x0
	public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain"; //Field offset: 0x0
	public const string k_pch_Power_Section = "power"; //Field offset: 0x0
	public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit"; //Field offset: 0x0
	public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout"; //Field offset: 0x0
	public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout"; //Field offset: 0x0
	public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout"; //Field offset: 0x0
	public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress"; //Field offset: 0x0
	public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby"; //Field offset: 0x0
	public const string k_pch_Dashboard_Section = "dashboard"; //Field offset: 0x0
	public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard"; //Field offset: 0x0
	public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode"; //Field offset: 0x0
	public const string k_pch_Dashboard_EnableWebUI = "webUI"; //Field offset: 0x0
	public const string k_pch_Dashboard_EnableWebUIDevTools = "webUIDevTools"; //Field offset: 0x0
	public const string k_pch_Dashboard_EnableWebUIDashboardReplacement = "webUIDashboard"; //Field offset: 0x0
	public const string k_pch_modelskin_Section = "modelskins"; //Field offset: 0x0
	public const string k_pch_DirectMode_EdidVid_Int32 = "edidVid"; //Field offset: 0x0
	private const string FnTable_Prefix = "FnTable:"; //Field offset: 0x0
	public const string k_pch_DirectMode_Count_Int32 = "count"; //Field offset: 0x0
	public const string k_pch_DirectMode_Section = "direct_mode"; //Field offset: 0x0
	public const uint k_unMaxPropertyStringSize = 32768; //Field offset: 0x0
	public const ulong k_ulInvalidActionHandle = 0; //Field offset: 0x0
	public const ulong k_ulInvalidActionSetHandle = 0; //Field offset: 0x0
	public const ulong k_ulInvalidInputValueHandle = 0; //Field offset: 0x0
	public const uint k_unControllerStateAxisCount = 5; //Field offset: 0x0
	public const ulong k_ulOverlayHandleInvalid = 0; //Field offset: 0x0
	public const uint k_unMaxDistortionFunctionParameters = 8; //Field offset: 0x0
	public const uint k_unScreenshotHandleInvalid = 0; //Field offset: 0x0
	public const string IVRSystem_Version = "IVRSystem_019"; //Field offset: 0x0
	public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001"; //Field offset: 0x0
	public const string IVRTrackedCamera_Version = "IVRTrackedCamera_005"; //Field offset: 0x0
	public const uint k_unMaxApplicationKeyLength = 128; //Field offset: 0x0
	public const uint k_unOpenVRInternalReserved_End = 10000; //Field offset: 0x0
	public const string k_pch_MimeType_HomeApp = "vr/home"; //Field offset: 0x0
	public const string IVRApplications_Version = "IVRApplications_006"; //Field offset: 0x0
	public const string IVRChaperone_Version = "IVRChaperone_003"; //Field offset: 0x0
	public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_006"; //Field offset: 0x0
	public const string IVRCompositor_Version = "IVRCompositor_022"; //Field offset: 0x0
	public const uint k_unVROverlayMaxKeyLength = 128; //Field offset: 0x0
	public const uint k_unVROverlayMaxNameLength = 128; //Field offset: 0x0
	public const uint k_unMaxOverlayCount = 64; //Field offset: 0x0
	public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32; //Field offset: 0x0
	public const string IVROverlay_Version = "IVROverlay_019"; //Field offset: 0x0
	public const string k_pch_Controller_Component_GDC2015 = "gdc2015"; //Field offset: 0x0
	public const string k_pch_Controller_Component_Base = "base"; //Field offset: 0x0
	public const string k_pch_Controller_Component_Tip = "tip"; //Field offset: 0x0
	public const string k_pch_MimeType_GameTheater = "vr/game_theater"; //Field offset: 0x0
	public const string k_pch_Controller_Component_HandGrip = "handgrip"; //Field offset: 0x0
	public const uint k_unOpenVRInternalReserved_Start = 1000; //Field offset: 0x0
	public const uint k_unSpatialAnchorPosePropertyTag = 40; //Field offset: 0x0
	public const uint k_unMaxDriverDebugResponseSize = 32768; //Field offset: 0x0
	public const uint k_unTrackedDeviceIndex_Hmd = 0; //Field offset: 0x0
	public const uint k_unMaxTrackedDeviceCount = 64; //Field offset: 0x0
	public const uint k_unTrackedDeviceIndexOther = 4294967294; //Field offset: 0x0
	public const uint k_unTrackedDeviceIndexInvalid = 4294967295; //Field offset: 0x0
	public const ulong k_ulInvalidPropertyContainer = 0; //Field offset: 0x0
	public const uint k_unInvalidPropertyTag = 0; //Field offset: 0x0
	public const ulong k_ulInvalidDriverHandle = 0; //Field offset: 0x0
	public const uint k_unFloatPropertyTag = 1; //Field offset: 0x0
	public const uint k_unInt32PropertyTag = 2; //Field offset: 0x0
	public const uint k_unUint64PropertyTag = 3; //Field offset: 0x0
	public const uint k_unBoolPropertyTag = 4; //Field offset: 0x0
	public const uint k_unJsonPropertyTag = 41; //Field offset: 0x0
	public const uint k_unStringPropertyTag = 5; //Field offset: 0x0
	public const uint k_unHmdMatrix44PropertyTag = 21; //Field offset: 0x0
	public const uint k_unHmdVector3PropertyTag = 22; //Field offset: 0x0
	public const uint k_unHmdVector4PropertyTag = 23; //Field offset: 0x0
	public const uint k_unHmdVector2PropertyTag = 24; //Field offset: 0x0
	public const uint k_unHmdQuadPropertyTag = 25; //Field offset: 0x0
	public const uint k_unHiddenAreaPropertyTag = 30; //Field offset: 0x0
	public const uint k_unPathHandleInfoTag = 31; //Field offset: 0x0
	public const uint k_unActionPropertyTag = 32; //Field offset: 0x0
	public const uint k_unInputValuePropertyTag = 33; //Field offset: 0x0
	public const uint k_unWildcardPropertyTag = 34; //Field offset: 0x0
	public const uint k_unHapticVibrationPropertyTag = 35; //Field offset: 0x0
	public const uint k_unSkeletonPropertyTag = 36; //Field offset: 0x0
	public const uint k_unHmdMatrix34PropertyTag = 20; //Field offset: 0x0
	public const string k_pch_Controller_Component_Status = "status"; //Field offset: 0x0
	public const string IVRRenderModels_Version = "IVRRenderModels_006"; //Field offset: 0x0
	public const uint k_unNotificationTextMaxSize = 256; //Field offset: 0x0
	public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "mirrorView"; //Field offset: 0x0
	public const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView"; //Field offset: 0x0
	public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry"; //Field offset: 0x0
	public const string k_pch_SteamVR_MirrorViewGeometryMaximized_String = "mirrorViewGeometryMaximized"; //Field offset: 0x0
	public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch"; //Field offset: 0x0
	public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch"; //Field offset: 0x0
	public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch"; //Field offset: 0x0
	public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard"; //Field offset: 0x0
	public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp"; //Field offset: 0x0
	public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec"; //Field offset: 0x0
	public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo"; //Field offset: 0x0
	public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset"; //Field offset: 0x0
	public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking"; //Field offset: 0x0
	public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering"; //Field offset: 0x0
	public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync"; //Field offset: 0x0
	public const string k_pch_SteamVR_AllowDisplayLockedMode_Bool = "allowDisplayLockedMode"; //Field offset: 0x0
	public const string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool = "haveStartedTutorialForNativeChaperoneDriver"; //Field offset: 0x0
	public const string k_pch_SteamVR_ForceWindows32bitVRMonitor = "forceWindows32BitVRMonitor"; //Field offset: 0x0
	public const string k_pch_SteamVR_DebugInput = "debugInput"; //Field offset: 0x0
	public const string k_pch_SteamVR_LegacyInputRebinding = "legacyInputRebinding"; //Field offset: 0x0
	public const string k_pch_SteamVR_DebugInputBinding = "debugInputBinding"; //Field offset: 0x0
	public const string k_pch_SteamVR_InputBindingUIBlock = "inputBindingUI"; //Field offset: 0x0
	public const string k_pch_SteamVR_RenderCameraMode = "renderCameraMode"; //Field offset: 0x0
	public const string k_pch_SteamVR_EnableSharedResourceJournaling = "enableSharedResourceJournaling"; //Field offset: 0x0
	public const string k_pch_SteamVR_EnableSafeMode = "enableSafeMode"; //Field offset: 0x0
	public const string k_pch_SteamVR_PreferredRefreshRate = "preferredRefreshRate"; //Field offset: 0x0
	public const string k_pch_SteamVR_SupersampleManualOverride_Bool = "supersampleManualOverride"; //Field offset: 0x0
	public const string k_pch_SteamVR_MotionSmoothingOverride_Int32 = "motionSmoothingOverride"; //Field offset: 0x0
	public const string k_pch_SteamVR_MotionSmoothing_Bool = "motionSmoothing"; //Field offset: 0x0
	public const string k_pch_SteamVR_MaxRecommendedResolution_Int32 = "maxRecommendedResolution"; //Field offset: 0x0
	public const string IVRNotifications_Version = "IVRNotifications_002"; //Field offset: 0x0
	public const uint k_unMaxSettingsKeyLength = 128; //Field offset: 0x0
	public const string IVRSettings_Version = "IVRSettings_002"; //Field offset: 0x0
	public const string k_pch_SteamVR_Section = "steamvr"; //Field offset: 0x0
	public const string k_pch_SteamVR_RequireHmd_String = "requireHmd"; //Field offset: 0x0
	public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver"; //Field offset: 0x0
	public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd"; //Field offset: 0x0
	public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug"; //Field offset: 0x0
	public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe"; //Field offset: 0x0
	public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX"; //Field offset: 0x0
	public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY"; //Field offset: 0x0
	public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps"; //Field offset: 0x0
	public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel"; //Field offset: 0x0
	public const string k_pch_SteamVR_IPD_Float = "ipd"; //Field offset: 0x0
	public const string k_pch_SteamVR_Background_String = "background"; //Field offset: 0x0
	public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection"; //Field offset: 0x0
	public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight"; //Field offset: 0x0
	public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius"; //Field offset: 0x0
	public const string k_pch_SteamVR_GridColor_String = "gridColor"; //Field offset: 0x0
	public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor"; //Field offset: 0x0
	public const string k_pch_SteamVR_ShowStage_Bool = "showStage"; //Field offset: 0x0
	public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers"; //Field offset: 0x0
	public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers"; //Field offset: 0x0
	public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees"; //Field offset: 0x0
	public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement"; //Field offset: 0x0
	public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses"; //Field offset: 0x0
	public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale"; //Field offset: 0x0
	public const string k_pch_DirectMode_Enable_Bool = "enable"; //Field offset: 0x0
	private static COpenVRContext _OpenVRInternal_ModuleContext; //Field offset: 0x8

	public static CVRApplications Applications
	{
		 get { } //Length: 383
	}

	public static CVRChaperone Chaperone
	{
		 get { } //Length: 383
	}

	public static CVRChaperoneSetup ChaperoneSetup
	{
		 get { } //Length: 383
	}

	public static CVRCompositor Compositor
	{
		 get { } //Length: 383
	}

	public static CVRExtendedDisplay ExtendedDisplay
	{
		 get { } //Length: 383
	}

	public static CVRInput Input
	{
		 get { } //Length: 383
	}

	private static COpenVRContext OpenVRInternal_ModuleContext
	{
		private get { } //Length: 258
	}

	public static CVROverlay Overlay
	{
		 get { } //Length: 383
	}

	public static CVRRenderModels RenderModels
	{
		 get { } //Length: 383
	}

	public static CVRScreenshots Screenshots
	{
		 get { } //Length: 383
	}

	public static CVRSettings Settings
	{
		 get { } //Length: 383
	}

	public static CVRSpatialAnchors SpatialAnchors
	{
		 get { } //Length: 383
	}

	public static CVRSystem System
	{
		 get { } //Length: 383
	}

	public static CVRTrackedCamera TrackedCamera
	{
		 get { } //Length: 383
	}

	private static uint VRToken
	{
		[CompilerGenerated]
		private get { } //Length: 85
		[CompilerGenerated]
		private set { } //Length: 90
	}

	private static OpenVR() { }

	public OpenVR() { }

	public static CVRApplications get_Applications() { }

	public static CVRChaperone get_Chaperone() { }

	public static CVRChaperoneSetup get_ChaperoneSetup() { }

	public static CVRCompositor get_Compositor() { }

	public static CVRExtendedDisplay get_ExtendedDisplay() { }

	public static CVRInput get_Input() { }

	private static COpenVRContext get_OpenVRInternal_ModuleContext() { }

	public static CVROverlay get_Overlay() { }

	public static CVRRenderModels get_RenderModels() { }

	public static CVRScreenshots get_Screenshots() { }

	public static CVRSettings get_Settings() { }

	public static CVRSpatialAnchors get_SpatialAnchors() { }

	public static CVRSystem get_System() { }

	public static CVRTrackedCamera get_TrackedCamera() { }

	[CompilerGenerated]
	private static uint get_VRToken() { }

	public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError) { }

	public static uint GetInitToken() { }

	public static string GetStringForHmdError(EVRInitError error) { }

	public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = 1, string pchStartupInfo = "") { }

	public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType) { }

	public static uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, string pchStartupInfo) { }

	public static bool IsHmdPresent() { }

	public static bool IsInterfaceVersionValid(string pchInterfaceVersion) { }

	public static bool IsRuntimeInstalled() { }

	public static string RuntimePath() { }

	[CompilerGenerated]
	private static void set_VRToken(uint value) { }

	public static void Shutdown() { }

	public static void ShutdownInternal() { }

}


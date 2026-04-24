namespace Steamworks;

public static class SteamUtils
{

	public static bool BOverlayNeedsPresent() { }

	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	public static AppId_t GetAppID() { }

	public static EUniverse GetConnectedUniverse() { }

	public static byte GetCurrentBatteryPower() { }

	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	public static uint GetEnteredGamepadTextLength() { }

	public static bool GetImageRGBA(int iImage, Byte[] pubDest, int nDestBufferSize) { }

	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	public static uint GetIPCCallCount() { }

	public static string GetIPCountry() { }

	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	public static uint GetSecondsSinceAppActive() { }

	public static uint GetSecondsSinceComputerActive() { }

	public static uint GetServerRealTime() { }

	public static string GetSteamUILanguage() { }

	public static bool InitFilterText(uint unFilterOptions = 0) { }

	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	public static bool IsOverlayEnabled() { }

	public static bool IsSteamChinaLauncher() { }

	public static bool IsSteamInBigPictureMode() { }

	public static bool IsSteamRunningInVR() { }

	public static bool IsSteamRunningOnSteamDeck() { }

	public static bool IsVRHeadsetStreamingEnabled() { }

	public static void SetGameLauncherMode(bool bLauncherMode) { }

	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	public static void StartVRDashboard() { }

}


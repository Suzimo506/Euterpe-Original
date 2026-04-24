namespace Steamworks;

public static class SteamApps
{

	public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) { }

	public static bool BIsAppInstalled(AppId_t appID) { }

	public static bool BIsCybercafe() { }

	public static bool BIsDlcInstalled(AppId_t appID) { }

	public static bool BIsLowViolence() { }

	public static bool BIsSubscribed() { }

	public static bool BIsSubscribedApp(AppId_t appID) { }

	public static bool BIsSubscribedFromFamilySharing() { }

	public static bool BIsSubscribedFromFreeWeekend() { }

	public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	public static bool BIsVACBanned() { }

	public static int GetAppBuildId() { }

	public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) { }

	public static CSteamID GetAppOwner() { }

	public static string GetAvailableGameLanguages() { }

	public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) { }

	public static string GetCurrentGameLanguage() { }

	public static int GetDLCCount() { }

	public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) { }

	public static SteamAPICall_t GetFileDetails(string pszFileName) { }

	public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) { }

	public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) { }

	public static string GetLaunchQueryParam(string pchKey) { }

	public static void InstallDLC(AppId_t nAppID) { }

	public static bool MarkContentCorrupt(bool bMissingFilesOnly) { }

	public static void RequestAllProofOfPurchaseKeys() { }

	public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) { }

	public static void UninstallDLC(AppId_t nAppID) { }

}


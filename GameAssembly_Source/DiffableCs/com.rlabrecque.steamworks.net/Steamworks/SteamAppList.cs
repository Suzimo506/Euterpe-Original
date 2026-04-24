namespace Steamworks;

public static class SteamAppList
{

	public static int GetAppBuildId(AppId_t nAppID) { }

	public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax) { }

	public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax) { }

	public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs) { }

	public static uint GetNumInstalledApps() { }

}


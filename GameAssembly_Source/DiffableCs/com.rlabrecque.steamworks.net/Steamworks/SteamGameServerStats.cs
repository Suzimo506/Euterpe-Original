namespace Steamworks;

public static class SteamGameServerStats
{

	public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) { }

	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) { }

	public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) { }

	public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) { }

	public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) { }

	public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) { }

}


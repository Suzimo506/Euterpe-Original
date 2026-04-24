namespace Steamworks;

public static class SteamUserStats
{

	public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	public static bool ClearAchievement(string pchName) { }

	public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers) { }

	public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName) { }

	public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	public static bool GetAchievement(string pchName, out bool pbAchieved) { }

	public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) { }

	public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	public static string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	public static int GetAchievementIcon(string pchName) { }

	public static string GetAchievementName(uint iAchievement) { }

	public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress) { }

	public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress) { }

	public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, Int32[] pDetails, int cDetailsMax) { }

	public static bool GetGlobalStat(string pchStatName, out double pData) { }

	public static bool GetGlobalStat(string pchStatName, out long pData) { }

	public static int GetGlobalStatHistory(string pchStatName, Double[] pData, uint cubData) { }

	public static int GetGlobalStatHistory(string pchStatName, Int64[] pData, uint cubData) { }

	public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard) { }

	public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard) { }

	public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard) { }

	public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard) { }

	public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	public static uint GetNumAchievements() { }

	public static SteamAPICall_t GetNumberOfCurrentPlayers() { }

	public static bool GetStat(string pchName, out float pData) { }

	public static bool GetStat(string pchName, out int pData) { }

	public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) { }

	public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) { }

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) { }

	public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) { }

	public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) { }

	public static bool RequestCurrentStats() { }

	public static SteamAPICall_t RequestGlobalAchievementPercentages() { }

	public static SteamAPICall_t RequestGlobalStats(int nHistoryDays) { }

	public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) { }

	public static bool ResetAllStats(bool bAchievementsToo) { }

	public static bool SetAchievement(string pchName) { }

	public static bool SetStat(string pchName, float fData) { }

	public static bool SetStat(string pchName, int nData) { }

	public static bool StoreStats() { }

	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) { }

	public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, Int32[] pScoreDetails, int cScoreDetailsCount) { }

}


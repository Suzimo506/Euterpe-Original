namespace Steamworks;

public static class SteamUser
{

	public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	public static EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	public static bool BIsBehindNAT() { }

	public static bool BIsPhoneIdentifying() { }

	public static bool BIsPhoneRequiringVerification() { }

	public static bool BIsPhoneVerified() { }

	public static bool BIsTwoFactorEnabled() { }

	public static bool BLoggedOn() { }

	public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState) { }

	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	public static EVoiceResult DecompressVoice(Byte[] pCompressed, uint cbCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	public static void EndAuthSession(CSteamID steamID) { }

	public static HAuthTicket GetAuthSessionTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static EVoiceResult GetAvailableVoice(out uint pcbCompressed) { }

	public static SteamAPICall_t GetDurationControl() { }

	public static bool GetEncryptedAppTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static int GetGameBadgeLevel(int nSeries, bool bFoil) { }

	public static HSteamUser GetHSteamUser() { }

	public static SteamAPICall_t GetMarketEligibility() { }

	public static int GetPlayerSteamLevel() { }

	public static CSteamID GetSteamID() { }

	public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer) { }

	public static EVoiceResult GetVoice(bool bWantCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten) { }

	public static uint GetVoiceOptimalSampleRate() { }

	public static int InitiateGameConnection_DEPRECATED(Byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	public static SteamAPICall_t RequestEncryptedAppTicket(Byte[] pDataToInclude, int cbDataToInclude) { }

	public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL) { }

	public static void StartVoiceRecording() { }

	public static void StopVoiceRecording() { }

	public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) { }

	public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "") { }

	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

}


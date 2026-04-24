namespace Steamworks;

public static class SteamGameServer
{

	public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) { }

	public static EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	public static bool BLoggedOn() { }

	public static bool BSecure() { }

	public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) { }

	public static void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	public static void ClearAllKeyValues() { }

	public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) { }

	public static CSteamID CreateUnauthenticatedUserConnection() { }

	public static void EndAuthSession(CSteamID steamID) { }

	public static HAuthTicket GetAuthSessionTicket(Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static void GetGameplayStats() { }

	public static int GetNextOutgoingPacket(Byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	public static SteamIPAddress_t GetPublicIP() { }

	public static SteamAPICall_t GetServerReputation() { }

	public static CSteamID GetSteamID() { }

	public static bool HandleIncomingPacket(Byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	public static void LogOff() { }

	public static void LogOn(string pszToken) { }

	public static void LogOnAnonymous() { }

	public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) { }

	public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, Byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser) { }

	public static void SetAdvertiseServerActive(bool bActive) { }

	public static void SetBotPlayerCount(int cBotplayers) { }

	public static void SetDedicatedServer(bool bDedicated) { }

	public static void SetGameData(string pchGameData) { }

	public static void SetGameDescription(string pszGameDescription) { }

	public static void SetGameTags(string pchGameTags) { }

	public static void SetKeyValue(string pKey, string pValue) { }

	public static void SetMapName(string pszMapName) { }

	public static void SetMaxPlayerCount(int cPlayersMax) { }

	public static void SetModDir(string pszModDir) { }

	public static void SetPasswordProtected(bool bPasswordProtected) { }

	public static void SetProduct(string pszProduct) { }

	public static void SetRegion(string pszRegion) { }

	public static void SetServerName(string pszServerName) { }

	public static void SetSpectatorPort(ushort unSpectatorPort) { }

	public static void SetSpectatorServerName(string pszSpectatorServerName) { }

	public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) { }

	public static bool WasRestartRequested() { }

}


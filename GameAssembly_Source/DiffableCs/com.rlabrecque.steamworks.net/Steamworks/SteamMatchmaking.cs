namespace Steamworks;

public static class SteamMatchmaking
{

	public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) { }

	public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) { }

	public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) { }

	public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) { }

	public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	public static void AddRequestLobbyListResultCountFilter(int cMaxResults) { }

	public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) { }

	public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) { }

	public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) { }

	public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	public static int GetFavoriteGameCount() { }

	public static CSteamID GetLobbyByIndex(int iLobby) { }

	public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, Byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) { }

	public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) { }

	public static int GetLobbyDataCount(CSteamID steamIDLobby) { }

	public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) { }

	public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) { }

	public static int GetLobbyMemberLimit(CSteamID steamIDLobby) { }

	public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) { }

	public static int GetNumLobbyMembers(CSteamID steamIDLobby) { }

	public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) { }

	public static void LeaveLobby(CSteamID steamIDLobby) { }

	public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	public static bool RequestLobbyData(CSteamID steamIDLobby) { }

	public static SteamAPICall_t RequestLobbyList() { }

	public static bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody, int cubMsgBody) { }

	public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }

	public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) { }

	public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) { }

	public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) { }

	public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) { }

}


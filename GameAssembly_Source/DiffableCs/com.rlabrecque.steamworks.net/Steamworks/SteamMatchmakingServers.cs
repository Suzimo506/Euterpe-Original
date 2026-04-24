namespace Steamworks;

public static class SteamMatchmakingServers
{

	public static void CancelQuery(HServerListRequest hRequest) { }

	public static void CancelServerQuery(HServerQuery hServerQuery) { }

	public static int GetServerCount(HServerListRequest hRequest) { }

	public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	public static bool IsRefreshing(HServerListRequest hRequest) { }

	public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) { }

	public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) { }

	public static void RefreshQuery(HServerListRequest hRequest) { }

	public static void RefreshServer(HServerListRequest hRequest, int iServer) { }

	public static void ReleaseRequest(HServerListRequest hServerListRequest) { }

	public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) { }

}


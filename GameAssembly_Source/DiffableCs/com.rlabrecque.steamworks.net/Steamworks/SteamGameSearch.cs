namespace Steamworks;

public static class SteamGameSearch
{

	public static EGameSearchErrorCode_t AcceptGame() { }

	public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind) { }

	public static EGameSearchErrorCode_t CancelRequestPlayersForGame() { }

	public static EGameSearchErrorCode_t DeclineGame() { }

	public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID) { }

	public static EGameSearchErrorCode_t EndGameSearch() { }

	public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID) { }

	public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails) { }

	public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax) { }

	public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails) { }

	public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue) { }

	public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

}


namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RequestPlayersForGameResultCallback_t
{
	public const int k_iCallback = 5212; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public ulong m_ullSearchID; //Field offset: 0x8
	public CSteamID m_SteamIDPlayerFound; //Field offset: 0x10
	public CSteamID m_SteamIDLobby; //Field offset: 0x18
	public PlayerAcceptState_t m_ePlayerAcceptState; //Field offset: 0x20
	public int m_nPlayerIndex; //Field offset: 0x24
	public int m_nTotalPlayersFound; //Field offset: 0x28
	public int m_nTotalPlayersAcceptedGame; //Field offset: 0x2C
	public int m_nSuggestedTeamIndex; //Field offset: 0x30
	public ulong m_ullUniqueGameID; //Field offset: 0x38

}


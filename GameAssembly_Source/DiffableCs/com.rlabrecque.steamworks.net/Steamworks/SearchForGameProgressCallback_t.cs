namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SearchForGameProgressCallback_t
{
	public const int k_iCallback = 5201; //Field offset: 0x0
	public ulong m_ullSearchID; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public CSteamID m_lobbyID; //Field offset: 0xC
	public CSteamID m_steamIDEndedSearch; //Field offset: 0x14
	public int m_nSecondsRemainingEstimate; //Field offset: 0x1C
	public int m_cPlayersSearching; //Field offset: 0x20

}


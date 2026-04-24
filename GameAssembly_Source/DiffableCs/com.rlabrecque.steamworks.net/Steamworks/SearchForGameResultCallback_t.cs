namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SearchForGameResultCallback_t
{
	public const int k_iCallback = 5202; //Field offset: 0x0
	public ulong m_ullSearchID; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public int m_nCountPlayersInGame; //Field offset: 0xC
	public int m_nCountAcceptedGame; //Field offset: 0x10
	public CSteamID m_steamIDHost; //Field offset: 0x14
	public bool m_bFinalCallback; //Field offset: 0x1C

}


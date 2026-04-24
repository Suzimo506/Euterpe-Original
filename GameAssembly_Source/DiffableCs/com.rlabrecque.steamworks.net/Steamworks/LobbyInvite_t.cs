namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyInvite_t
{
	public const int k_iCallback = 503; //Field offset: 0x0
	public ulong m_ulSteamIDUser; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x8
	public ulong m_ulGameID; //Field offset: 0x10

}


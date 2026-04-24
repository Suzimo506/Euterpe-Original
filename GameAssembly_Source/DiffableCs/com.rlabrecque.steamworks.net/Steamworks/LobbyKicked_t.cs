namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyKicked_t
{
	public const int k_iCallback = 512; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public ulong m_ulSteamIDAdmin; //Field offset: 0x8
	public byte m_bKickedDueToDisconnect; //Field offset: 0x10

}


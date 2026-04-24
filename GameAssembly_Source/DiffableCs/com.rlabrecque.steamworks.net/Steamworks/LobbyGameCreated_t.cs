namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyGameCreated_t
{
	public const int k_iCallback = 509; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public ulong m_ulSteamIDGameServer; //Field offset: 0x8
	public uint m_unIP; //Field offset: 0x10
	public ushort m_usPort; //Field offset: 0x14

}


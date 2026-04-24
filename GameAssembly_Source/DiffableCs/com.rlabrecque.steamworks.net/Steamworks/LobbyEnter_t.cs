namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyEnter_t
{
	public const int k_iCallback = 504; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public uint m_rgfChatPermissions; //Field offset: 0x8
	public bool m_bLocked; //Field offset: 0xC
	public uint m_EChatRoomEnterResponse; //Field offset: 0x10

}


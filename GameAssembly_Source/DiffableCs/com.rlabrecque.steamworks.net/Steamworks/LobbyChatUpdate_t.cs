namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyChatUpdate_t
{
	public const int k_iCallback = 506; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public ulong m_ulSteamIDUserChanged; //Field offset: 0x8
	public ulong m_ulSteamIDMakingChange; //Field offset: 0x10
	public uint m_rgfChatMemberStateChange; //Field offset: 0x18

}


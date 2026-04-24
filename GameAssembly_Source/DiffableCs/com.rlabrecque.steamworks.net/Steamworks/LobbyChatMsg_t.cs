namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LobbyChatMsg_t
{
	public const int k_iCallback = 507; //Field offset: 0x0
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	public ulong m_ulSteamIDUser; //Field offset: 0x8
	public byte m_eChatEntryType; //Field offset: 0x10
	public uint m_iChatID; //Field offset: 0x14

}


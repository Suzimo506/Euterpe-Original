namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct JoinClanChatRoomCompletionResult_t
{
	public const int k_iCallback = 342; //Field offset: 0x0
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	public EChatRoomEnterResponse m_eChatRoomEnterResponse; //Field offset: 0x8

}


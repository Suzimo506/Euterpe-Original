namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GameConnectedClanChatMsg_t
{
	public const int k_iCallback = 338; //Field offset: 0x0
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	public CSteamID m_steamIDUser; //Field offset: 0x8
	public int m_iMessageID; //Field offset: 0x10

}


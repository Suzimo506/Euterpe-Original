namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GameConnectedChatLeave_t
{
	public const int k_iCallback = 340; //Field offset: 0x0
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	public CSteamID m_steamIDUser; //Field offset: 0x8
	public bool m_bKicked; //Field offset: 0x10
	public bool m_bDropped; //Field offset: 0x11

}


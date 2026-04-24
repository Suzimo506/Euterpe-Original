namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct GameConnectedChatJoin_t
{
	public const int k_iCallback = 339; //Field offset: 0x0
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	public CSteamID m_steamIDUser; //Field offset: 0x8

}


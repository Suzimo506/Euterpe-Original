namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct P2PSessionConnectFail_t
{
	public const int k_iCallback = 1203; //Field offset: 0x0
	public CSteamID m_steamIDRemote; //Field offset: 0x0
	public byte m_eP2PSessionError; //Field offset: 0x8

}


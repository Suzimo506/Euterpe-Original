namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamNetConnectionStatusChangedCallback_t
{
	public const int k_iCallback = 1221; //Field offset: 0x0
	public HSteamNetConnection m_hConn; //Field offset: 0x0
	public SteamNetConnectionInfo_t m_info; //Field offset: 0x8
	public ESteamNetworkingConnectionState m_eOldState; //Field offset: 0x68

}


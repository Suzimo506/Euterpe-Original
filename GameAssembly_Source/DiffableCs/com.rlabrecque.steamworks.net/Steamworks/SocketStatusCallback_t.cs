namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SocketStatusCallback_t
{
	public const int k_iCallback = 1201; //Field offset: 0x0
	public SNetSocket_t m_hSocket; //Field offset: 0x0
	public SNetListenSocket_t m_hListenSocket; //Field offset: 0x4
	public CSteamID m_steamIDRemote; //Field offset: 0x8
	public int m_eSNetSocketState; //Field offset: 0x10

}


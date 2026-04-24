namespace Steamworks;

public struct SteamNetConnectionInfo_t
{
	public SteamNetworkingIdentity m_identityRemote; //Field offset: 0x0
	public long m_nUserData; //Field offset: 0x10
	public HSteamListenSocket m_hListenSocket; //Field offset: 0x18
	public SteamNetworkingIPAddr m_addrRemote; //Field offset: 0x20
	public ushort m__pad1; //Field offset: 0x30
	public SteamNetworkingPOPID m_idPOPRemote; //Field offset: 0x34
	public SteamNetworkingPOPID m_idPOPRelay; //Field offset: 0x38
	public ESteamNetworkingConnectionState m_eState; //Field offset: 0x3C
	public int m_eEndReason; //Field offset: 0x40
	private Byte[] m_szEndDebug_; //Field offset: 0x48
	private Byte[] m_szConnectionDescription_; //Field offset: 0x50
	public UInt32[] reserved; //Field offset: 0x58

	public string m_szConnectionDescription
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string m_szEndDebug
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_szConnectionDescription() { }

	public string get_m_szEndDebug() { }

	public void set_m_szConnectionDescription(string value) { }

	public void set_m_szEndDebug(string value) { }

}


namespace Steamworks;

public struct SteamIPAddress_t
{
	private long m_ip0; //Field offset: 0x0
	private long m_ip1; //Field offset: 0x8
	private ESteamIPType m_eType; //Field offset: 0x10

	public SteamIPAddress_t(IPAddress iPAddress) { }

	public ESteamIPType GetIPType() { }

	public bool IsSet() { }

	public IPAddress ToIPAddress() { }

	public virtual string ToString() { }

}


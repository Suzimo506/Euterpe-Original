namespace Steamworks;

public struct SteamNetworkingIPAddr : IEquatable<SteamNetworkingIPAddr>
{
	public const int k_cchMaxString = 48; //Field offset: 0x0
	public Byte[] m_ipv6; //Field offset: 0x0
	public ushort m_port; //Field offset: 0x8

	public void Clear() { }

	public override bool Equals(SteamNetworkingIPAddr x) { }

	public uint GetIPv4() { }

	public bool IsIPv4() { }

	public bool IsIPv6AllZeros() { }

	public bool IsLocalHost() { }

	public bool ParseString(string pszStr) { }

	public void SetIPv4(uint nIP, ushort nPort) { }

	public void SetIPv6(Byte[] ipv6, ushort nPort) { }

	public void SetIPv6LocalHost(ushort nPort = 0) { }

	public void ToString(out string buf, bool bWithPort) { }

}


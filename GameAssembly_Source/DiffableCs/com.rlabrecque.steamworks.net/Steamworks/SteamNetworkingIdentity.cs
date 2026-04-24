namespace Steamworks;

public struct SteamNetworkingIdentity : IEquatable<SteamNetworkingIdentity>
{
	public const int k_cchMaxString = 128; //Field offset: 0x0
	public const int k_cchMaxGenericString = 32; //Field offset: 0x0
	public const int k_cbMaxGenericBytes = 32; //Field offset: 0x0
	public ESteamNetworkingIdentityType m_eType; //Field offset: 0x0
	private int m_cbSize; //Field offset: 0x4
	private UInt32[] m_reserved; //Field offset: 0x8

	public void Clear() { }

	public override bool Equals(SteamNetworkingIdentity x) { }

	public Byte[] GetGenericBytes(out int cbLen) { }

	public string GetGenericString() { }

	public SteamNetworkingIPAddr GetIPAddr() { }

	public CSteamID GetSteamID() { }

	public ulong GetSteamID64() { }

	public bool IsInvalid() { }

	public bool IsLocalHost() { }

	public bool ParseString(string pszStr) { }

	public bool SetGenericBytes(Byte[] data, uint cbLen) { }

	public bool SetGenericString(string pszString) { }

	public void SetIPAddr(SteamNetworkingIPAddr addr) { }

	public void SetLocalHost() { }

	public void SetSteamID(CSteamID steamID) { }

	public void SetSteamID64(ulong steamID) { }

	public void ToString(out string buf) { }

}


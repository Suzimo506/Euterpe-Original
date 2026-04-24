namespace Steamworks;

public struct SteamNetworkingMicroseconds : IEquatable<SteamNetworkingMicroseconds>, IComparable<SteamNetworkingMicroseconds>
{
	public long m_SteamNetworkingMicroseconds; //Field offset: 0x0

	public SteamNetworkingMicroseconds(long value) { }

	public override int CompareTo(SteamNetworkingMicroseconds other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamNetworkingMicroseconds other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	public static SteamNetworkingMicroseconds op_Explicit(long value) { }

	public static long op_Explicit(SteamNetworkingMicroseconds that) { }

	public static bool op_Inequality(SteamNetworkingMicroseconds x, SteamNetworkingMicroseconds y) { }

	public virtual string ToString() { }

}


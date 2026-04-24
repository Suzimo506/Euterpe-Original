namespace Steamworks;

public struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
{
	public uint m_SteamNetworkingPOPID; //Field offset: 0x0

	public SteamNetworkingPOPID(uint value) { }

	public override int CompareTo(SteamNetworkingPOPID other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamNetworkingPOPID other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	public static SteamNetworkingPOPID op_Explicit(uint value) { }

	public static uint op_Explicit(SteamNetworkingPOPID that) { }

	public static bool op_Inequality(SteamNetworkingPOPID x, SteamNetworkingPOPID y) { }

	public virtual string ToString() { }

}


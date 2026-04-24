namespace Steamworks;

public struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
{
	public static readonly HSteamNetConnection Invalid; //Field offset: 0x0
	public uint m_HSteamNetConnection; //Field offset: 0x0

	private static HSteamNetConnection() { }

	public HSteamNetConnection(uint value) { }

	public override int CompareTo(HSteamNetConnection other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HSteamNetConnection other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HSteamNetConnection x, HSteamNetConnection y) { }

	public static HSteamNetConnection op_Explicit(uint value) { }

	public static uint op_Explicit(HSteamNetConnection that) { }

	public static bool op_Inequality(HSteamNetConnection x, HSteamNetConnection y) { }

	public virtual string ToString() { }

}


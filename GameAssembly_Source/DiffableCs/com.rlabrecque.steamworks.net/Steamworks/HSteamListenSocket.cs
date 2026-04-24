namespace Steamworks;

public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
{
	public static readonly HSteamListenSocket Invalid; //Field offset: 0x0
	public uint m_HSteamListenSocket; //Field offset: 0x0

	private static HSteamListenSocket() { }

	public HSteamListenSocket(uint value) { }

	public override int CompareTo(HSteamListenSocket other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HSteamListenSocket other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HSteamListenSocket x, HSteamListenSocket y) { }

	public static HSteamListenSocket op_Explicit(uint value) { }

	public static uint op_Explicit(HSteamListenSocket that) { }

	public static bool op_Inequality(HSteamListenSocket x, HSteamListenSocket y) { }

	public virtual string ToString() { }

}


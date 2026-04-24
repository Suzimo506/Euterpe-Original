namespace Steamworks;

public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
{
	public static readonly SteamItemInstanceID_t Invalid; //Field offset: 0x0
	public ulong m_SteamItemInstanceID; //Field offset: 0x0

	private static SteamItemInstanceID_t() { }

	public SteamItemInstanceID_t(ulong value) { }

	public override int CompareTo(SteamItemInstanceID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamItemInstanceID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	public static SteamItemInstanceID_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(SteamItemInstanceID_t that) { }

	public static bool op_Inequality(SteamItemInstanceID_t x, SteamItemInstanceID_t y) { }

	public virtual string ToString() { }

}


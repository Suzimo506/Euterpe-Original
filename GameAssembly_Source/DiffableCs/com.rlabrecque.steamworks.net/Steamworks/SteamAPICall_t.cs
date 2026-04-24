namespace Steamworks;

public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
{
	public static readonly SteamAPICall_t Invalid; //Field offset: 0x0
	public ulong m_SteamAPICall; //Field offset: 0x0

	private static SteamAPICall_t() { }

	public SteamAPICall_t(ulong value) { }

	public override int CompareTo(SteamAPICall_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamAPICall_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamAPICall_t x, SteamAPICall_t y) { }

	public static SteamAPICall_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(SteamAPICall_t that) { }

	public static bool op_Inequality(SteamAPICall_t x, SteamAPICall_t y) { }

	public virtual string ToString() { }

}


namespace Steamworks;

public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
{
	public static readonly SteamInventoryResult_t Invalid; //Field offset: 0x0
	public int m_SteamInventoryResult; //Field offset: 0x0

	private static SteamInventoryResult_t() { }

	public SteamInventoryResult_t(int value) { }

	public override int CompareTo(SteamInventoryResult_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamInventoryResult_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	public static SteamInventoryResult_t op_Explicit(int value) { }

	public static int op_Explicit(SteamInventoryResult_t that) { }

	public static bool op_Inequality(SteamInventoryResult_t x, SteamInventoryResult_t y) { }

	public virtual string ToString() { }

}


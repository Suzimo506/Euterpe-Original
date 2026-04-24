namespace Steamworks;

public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
{
	public static readonly SteamInventoryUpdateHandle_t Invalid; //Field offset: 0x0
	public ulong m_SteamInventoryUpdateHandle; //Field offset: 0x0

	private static SteamInventoryUpdateHandle_t() { }

	public SteamInventoryUpdateHandle_t(ulong value) { }

	public override int CompareTo(SteamInventoryUpdateHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamInventoryUpdateHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	public static SteamInventoryUpdateHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(SteamInventoryUpdateHandle_t that) { }

	public static bool op_Inequality(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) { }

	public virtual string ToString() { }

}


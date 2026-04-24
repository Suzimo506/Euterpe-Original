namespace Steamworks;

public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
{
	public int m_SteamItemDef; //Field offset: 0x0

	public SteamItemDef_t(int value) { }

	public override int CompareTo(SteamItemDef_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamItemDef_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamItemDef_t x, SteamItemDef_t y) { }

	public static SteamItemDef_t op_Explicit(int value) { }

	public static int op_Explicit(SteamItemDef_t that) { }

	public static bool op_Inequality(SteamItemDef_t x, SteamItemDef_t y) { }

	public virtual string ToString() { }

}


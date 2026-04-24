namespace Steamworks;

public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
{
	public static readonly DepotId_t Invalid; //Field offset: 0x0
	public uint m_DepotId; //Field offset: 0x0

	private static DepotId_t() { }

	public DepotId_t(uint value) { }

	public override int CompareTo(DepotId_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(DepotId_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(DepotId_t x, DepotId_t y) { }

	public static DepotId_t op_Explicit(uint value) { }

	public static uint op_Explicit(DepotId_t that) { }

	public static bool op_Inequality(DepotId_t x, DepotId_t y) { }

	public virtual string ToString() { }

}


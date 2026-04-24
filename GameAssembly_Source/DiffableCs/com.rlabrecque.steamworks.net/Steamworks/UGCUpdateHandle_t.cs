namespace Steamworks;

public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
{
	public static readonly UGCUpdateHandle_t Invalid; //Field offset: 0x0
	public ulong m_UGCUpdateHandle; //Field offset: 0x0

	private static UGCUpdateHandle_t() { }

	public UGCUpdateHandle_t(ulong value) { }

	public override int CompareTo(UGCUpdateHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(UGCUpdateHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	public static UGCUpdateHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(UGCUpdateHandle_t that) { }

	public static bool op_Inequality(UGCUpdateHandle_t x, UGCUpdateHandle_t y) { }

	public virtual string ToString() { }

}


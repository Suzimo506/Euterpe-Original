namespace Steamworks;

public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
{
	public static readonly UGCQueryHandle_t Invalid; //Field offset: 0x0
	public ulong m_UGCQueryHandle; //Field offset: 0x0

	private static UGCQueryHandle_t() { }

	public UGCQueryHandle_t(ulong value) { }

	public override int CompareTo(UGCQueryHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(UGCQueryHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	public static UGCQueryHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(UGCQueryHandle_t that) { }

	public static bool op_Inequality(UGCQueryHandle_t x, UGCQueryHandle_t y) { }

	public virtual string ToString() { }

}


namespace Steamworks;

public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
{
	public static readonly UGCHandle_t Invalid; //Field offset: 0x0
	public ulong m_UGCHandle; //Field offset: 0x0

	private static UGCHandle_t() { }

	public UGCHandle_t(ulong value) { }

	public override int CompareTo(UGCHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(UGCHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UGCHandle_t x, UGCHandle_t y) { }

	public static UGCHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(UGCHandle_t that) { }

	public static bool op_Inequality(UGCHandle_t x, UGCHandle_t y) { }

	public virtual string ToString() { }

}


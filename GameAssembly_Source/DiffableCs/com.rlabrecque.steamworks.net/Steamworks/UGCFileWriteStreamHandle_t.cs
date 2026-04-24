namespace Steamworks;

public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
{
	public static readonly UGCFileWriteStreamHandle_t Invalid; //Field offset: 0x0
	public ulong m_UGCFileWriteStreamHandle; //Field offset: 0x0

	private static UGCFileWriteStreamHandle_t() { }

	public UGCFileWriteStreamHandle_t(ulong value) { }

	public override int CompareTo(UGCFileWriteStreamHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(UGCFileWriteStreamHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	public static UGCFileWriteStreamHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(UGCFileWriteStreamHandle_t that) { }

	public static bool op_Inequality(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y) { }

	public virtual string ToString() { }

}


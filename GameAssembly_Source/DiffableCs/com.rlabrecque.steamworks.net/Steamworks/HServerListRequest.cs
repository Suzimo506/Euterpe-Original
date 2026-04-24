namespace Steamworks;

public struct HServerListRequest : IEquatable<HServerListRequest>
{
	public static readonly HServerListRequest Invalid; //Field offset: 0x0
	public IntPtr m_HServerListRequest; //Field offset: 0x0

	private static HServerListRequest() { }

	public HServerListRequest(IntPtr value) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HServerListRequest other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HServerListRequest x, HServerListRequest y) { }

	public static HServerListRequest op_Explicit(IntPtr value) { }

	public static IntPtr op_Explicit(HServerListRequest that) { }

	public static bool op_Inequality(HServerListRequest x, HServerListRequest y) { }

	public virtual string ToString() { }

}


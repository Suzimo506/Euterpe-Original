namespace Steamworks;

public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
{
	public static readonly HServerQuery Invalid; //Field offset: 0x0
	public int m_HServerQuery; //Field offset: 0x0

	private static HServerQuery() { }

	public HServerQuery(int value) { }

	public override int CompareTo(HServerQuery other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HServerQuery other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HServerQuery x, HServerQuery y) { }

	public static HServerQuery op_Explicit(int value) { }

	public static int op_Explicit(HServerQuery that) { }

	public static bool op_Inequality(HServerQuery x, HServerQuery y) { }

	public virtual string ToString() { }

}


namespace rail;

public class RailComparableID : IEquatable<RailComparableID>, IComparable<RailComparableID>
{
	public static readonly RailComparableID Nil; //Field offset: 0x0
	public ulong id_; //Field offset: 0x10

	private static RailComparableID() { }

	public RailComparableID() { }

	public RailComparableID(ulong id) { }

	public override int CompareTo(RailComparableID other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(RailComparableID other) { }

	public virtual int GetHashCode() { }

	public bool IsValid() { }

	public static bool op_Equality(RailComparableID x, RailComparableID y) { }

	public static RailComparableID op_Explicit(ulong value) { }

	public static ulong op_Explicit(RailComparableID that) { }

	public static bool op_Inequality(RailComparableID x, RailComparableID y) { }

	public virtual string ToString() { }

}


namespace Steamworks;

public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
{
	public static readonly FriendsGroupID_t Invalid; //Field offset: 0x0
	public short m_FriendsGroupID; //Field offset: 0x0

	private static FriendsGroupID_t() { }

	public FriendsGroupID_t(short value) { }

	public override int CompareTo(FriendsGroupID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(FriendsGroupID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	public static FriendsGroupID_t op_Explicit(short value) { }

	public static short op_Explicit(FriendsGroupID_t that) { }

	public static bool op_Inequality(FriendsGroupID_t x, FriendsGroupID_t y) { }

	public virtual string ToString() { }

}


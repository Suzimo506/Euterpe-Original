namespace Steamworks;

public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
{
	public int m_HSteamUser; //Field offset: 0x0

	public HSteamUser(int value) { }

	public override int CompareTo(HSteamUser other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HSteamUser other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HSteamUser x, HSteamUser y) { }

	public static HSteamUser op_Explicit(int value) { }

	public static int op_Explicit(HSteamUser that) { }

	public static bool op_Inequality(HSteamUser x, HSteamUser y) { }

	public virtual string ToString() { }

}


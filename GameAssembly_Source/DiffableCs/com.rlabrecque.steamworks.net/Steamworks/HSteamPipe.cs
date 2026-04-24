namespace Steamworks;

public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
{
	public int m_HSteamPipe; //Field offset: 0x0

	public HSteamPipe(int value) { }

	public override int CompareTo(HSteamPipe other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HSteamPipe other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HSteamPipe x, HSteamPipe y) { }

	public static HSteamPipe op_Explicit(int value) { }

	public static int op_Explicit(HSteamPipe that) { }

	public static bool op_Inequality(HSteamPipe x, HSteamPipe y) { }

	public virtual string ToString() { }

}


namespace Steamworks;

public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
{
	public ulong m_SteamLeaderboard; //Field offset: 0x0

	public SteamLeaderboard_t(ulong value) { }

	public override int CompareTo(SteamLeaderboard_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamLeaderboard_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	public static SteamLeaderboard_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(SteamLeaderboard_t that) { }

	public static bool op_Inequality(SteamLeaderboard_t x, SteamLeaderboard_t y) { }

	public virtual string ToString() { }

}


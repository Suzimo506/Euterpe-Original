namespace Steamworks;

public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
{
	public ulong m_SteamLeaderboardEntries; //Field offset: 0x0

	public SteamLeaderboardEntries_t(ulong value) { }

	public override int CompareTo(SteamLeaderboardEntries_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SteamLeaderboardEntries_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	public static SteamLeaderboardEntries_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(SteamLeaderboardEntries_t that) { }

	public static bool op_Inequality(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y) { }

	public virtual string ToString() { }

}


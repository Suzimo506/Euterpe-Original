namespace Steamworks;

public struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
{
	public static readonly HSteamNetPollGroup Invalid; //Field offset: 0x0
	public uint m_HSteamNetPollGroup; //Field offset: 0x0

	private static HSteamNetPollGroup() { }

	public HSteamNetPollGroup(uint value) { }

	public override int CompareTo(HSteamNetPollGroup other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HSteamNetPollGroup other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	public static HSteamNetPollGroup op_Explicit(uint value) { }

	public static uint op_Explicit(HSteamNetPollGroup that) { }

	public static bool op_Inequality(HSteamNetPollGroup x, HSteamNetPollGroup y) { }

	public virtual string ToString() { }

}


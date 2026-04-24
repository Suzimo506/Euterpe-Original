namespace Steamworks;

public struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
{
	public static readonly PartyBeaconID_t Invalid; //Field offset: 0x0
	public ulong m_PartyBeaconID; //Field offset: 0x0

	private static PartyBeaconID_t() { }

	public PartyBeaconID_t(ulong value) { }

	public override int CompareTo(PartyBeaconID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(PartyBeaconID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	public static PartyBeaconID_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(PartyBeaconID_t that) { }

	public static bool op_Inequality(PartyBeaconID_t x, PartyBeaconID_t y) { }

	public virtual string ToString() { }

}


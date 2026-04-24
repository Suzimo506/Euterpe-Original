namespace Steamworks;

public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
{
	public static readonly HAuthTicket Invalid; //Field offset: 0x0
	public uint m_HAuthTicket; //Field offset: 0x0

	private static HAuthTicket() { }

	public HAuthTicket(uint value) { }

	public override int CompareTo(HAuthTicket other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HAuthTicket other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HAuthTicket x, HAuthTicket y) { }

	public static HAuthTicket op_Explicit(uint value) { }

	public static uint op_Explicit(HAuthTicket that) { }

	public static bool op_Inequality(HAuthTicket x, HAuthTicket y) { }

	public virtual string ToString() { }

}


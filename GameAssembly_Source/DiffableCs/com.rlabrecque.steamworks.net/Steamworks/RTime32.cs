namespace Steamworks;

public struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
{
	public uint m_RTime32; //Field offset: 0x0

	public RTime32(uint value) { }

	public override int CompareTo(RTime32 other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(RTime32 other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RTime32 x, RTime32 y) { }

	public static RTime32 op_Explicit(uint value) { }

	public static uint op_Explicit(RTime32 that) { }

	public static bool op_Inequality(RTime32 x, RTime32 y) { }

	public virtual string ToString() { }

}


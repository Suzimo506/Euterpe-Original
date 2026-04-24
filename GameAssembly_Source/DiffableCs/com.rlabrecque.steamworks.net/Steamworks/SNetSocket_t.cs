namespace Steamworks;

public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
{
	public uint m_SNetSocket; //Field offset: 0x0

	public SNetSocket_t(uint value) { }

	public override int CompareTo(SNetSocket_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SNetSocket_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SNetSocket_t x, SNetSocket_t y) { }

	public static SNetSocket_t op_Explicit(uint value) { }

	public static uint op_Explicit(SNetSocket_t that) { }

	public static bool op_Inequality(SNetSocket_t x, SNetSocket_t y) { }

	public virtual string ToString() { }

}


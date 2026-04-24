namespace Steamworks;

public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
{
	public uint m_SNetListenSocket; //Field offset: 0x0

	public SNetListenSocket_t(uint value) { }

	public override int CompareTo(SNetListenSocket_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(SNetListenSocket_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	public static SNetListenSocket_t op_Explicit(uint value) { }

	public static uint op_Explicit(SNetListenSocket_t that) { }

	public static bool op_Inequality(SNetListenSocket_t x, SNetListenSocket_t y) { }

	public virtual string ToString() { }

}


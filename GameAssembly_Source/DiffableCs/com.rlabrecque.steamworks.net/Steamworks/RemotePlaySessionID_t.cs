namespace Steamworks;

public struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
{
	public uint m_RemotePlaySessionID; //Field offset: 0x0

	public RemotePlaySessionID_t(uint value) { }

	public override int CompareTo(RemotePlaySessionID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(RemotePlaySessionID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	public static RemotePlaySessionID_t op_Explicit(uint value) { }

	public static uint op_Explicit(RemotePlaySessionID_t that) { }

	public static bool op_Inequality(RemotePlaySessionID_t x, RemotePlaySessionID_t y) { }

	public virtual string ToString() { }

}


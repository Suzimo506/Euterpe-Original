namespace Steamworks;

public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
{
	public static readonly HTTPRequestHandle Invalid; //Field offset: 0x0
	public uint m_HTTPRequestHandle; //Field offset: 0x0

	private static HTTPRequestHandle() { }

	public HTTPRequestHandle(uint value) { }

	public override int CompareTo(HTTPRequestHandle other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HTTPRequestHandle other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	public static HTTPRequestHandle op_Explicit(uint value) { }

	public static uint op_Explicit(HTTPRequestHandle that) { }

	public static bool op_Inequality(HTTPRequestHandle x, HTTPRequestHandle y) { }

	public virtual string ToString() { }

}


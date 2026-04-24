namespace Steamworks;

public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
{
	public static readonly HTTPCookieContainerHandle Invalid; //Field offset: 0x0
	public uint m_HTTPCookieContainerHandle; //Field offset: 0x0

	private static HTTPCookieContainerHandle() { }

	public HTTPCookieContainerHandle(uint value) { }

	public override int CompareTo(HTTPCookieContainerHandle other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HTTPCookieContainerHandle other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	public static HTTPCookieContainerHandle op_Explicit(uint value) { }

	public static uint op_Explicit(HTTPCookieContainerHandle that) { }

	public static bool op_Inequality(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y) { }

	public virtual string ToString() { }

}


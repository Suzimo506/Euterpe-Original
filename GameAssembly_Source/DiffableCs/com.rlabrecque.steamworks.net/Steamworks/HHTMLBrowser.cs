namespace Steamworks;

public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
{
	public static readonly HHTMLBrowser Invalid; //Field offset: 0x0
	public uint m_HHTMLBrowser; //Field offset: 0x0

	private static HHTMLBrowser() { }

	public HHTMLBrowser(uint value) { }

	public override int CompareTo(HHTMLBrowser other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(HHTMLBrowser other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HHTMLBrowser x, HHTMLBrowser y) { }

	public static HHTMLBrowser op_Explicit(uint value) { }

	public static uint op_Explicit(HHTMLBrowser that) { }

	public static bool op_Inequality(HHTMLBrowser x, HHTMLBrowser y) { }

	public virtual string ToString() { }

}


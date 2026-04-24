namespace Steamworks;

public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
{
	public static readonly ScreenshotHandle Invalid; //Field offset: 0x0
	public uint m_ScreenshotHandle; //Field offset: 0x0

	private static ScreenshotHandle() { }

	public ScreenshotHandle(uint value) { }

	public override int CompareTo(ScreenshotHandle other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(ScreenshotHandle other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ScreenshotHandle x, ScreenshotHandle y) { }

	public static ScreenshotHandle op_Explicit(uint value) { }

	public static uint op_Explicit(ScreenshotHandle that) { }

	public static bool op_Inequality(ScreenshotHandle x, ScreenshotHandle y) { }

	public virtual string ToString() { }

}


namespace System;

[Extension]
public static class MemoryExtensions
{
	internal static readonly IntPtr StringAdjustment; //Field offset: 0x2C927BC

	private static MemoryExtensions() { }

	[Extension]
	public static Memory<T> AsMemory(T[] array) { }

	[Extension]
	public static ReadOnlyMemory<Char> AsMemory(string text, int start, int length) { }

	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text) { }

	private static bool IsTypeComparableAsBytes(out NUInt size) { }

	private static IntPtr MeasureStringAdjustment() { }

	[Extension]
	public static bool SequenceEqual(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }

}


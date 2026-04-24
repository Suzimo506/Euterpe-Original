namespace System;

[Extension]
internal static class SpanHelpers
{
	internal static class PerTypeValues
	{
		public static readonly bool IsReferenceOrContainsReferences; //Field offset: 0x0
		public static readonly T[] EmptyArray; //Field offset: 0x0
		public static readonly IntPtr ArrayAdjustment; //Field offset: 0x0

		private static PerTypeValues`1() { }

		private static IntPtr MeasureArrayAdjustment() { }

	}

	private struct Reg16
	{

	}

	private struct Reg32
	{

	}

	private struct Reg64
	{

	}


	[Extension]
	public static IntPtr Add(IntPtr start, int index) { }

	public static void ClearLessThanPointerSized(Byte* ptr, UIntPtr byteLength) { }

	public static void ClearLessThanPointerSized(ref byte b, UIntPtr byteLength) { }

	public static void ClearPointerSizedWithoutReferences(ref byte b, UIntPtr byteLength) { }

	public static void ClearPointerSizedWithReferences(ref IntPtr ip, UIntPtr pointerSizeLength) { }

	public static void CopyTo(ref T dst, int dstLength, ref T src, int srcLength) { }

	public static bool IsReferenceOrContainsReferences() { }

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

	[Extension]
	private static bool LessThanEqual(IntPtr index, UIntPtr length) { }

	public static bool SequenceEqual(ref byte first, ref byte second, NUInt length) { }

	public static bool SequenceEqual(ref T first, ref T second, int length) { }

}


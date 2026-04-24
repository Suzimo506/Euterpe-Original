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


	public static bool IsReferenceOrContainsReferences() { }

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}


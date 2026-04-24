namespace System.Numerics;

internal static class BigNumber
{
	private struct BigNumberBuffer
	{
		public StringBuilder digits; //Field offset: 0x0
		public int precision; //Field offset: 0x8
		public int scale; //Field offset: 0xC
		public bool sign; //Field offset: 0x10

		public static BigNumberBuffer Create() { }

	}


	private static ReadOnlySpan<Char> AsReadOnlySpan(string s) { }

	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	internal static BigInteger ParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info) { }

	internal static char ParseFormatSpecifier(string format, out int digits) { }

	internal static bool TryParseBigInteger(ReadOnlySpan<Char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

}


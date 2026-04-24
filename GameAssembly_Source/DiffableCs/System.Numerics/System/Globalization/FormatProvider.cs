namespace System.Globalization;

internal class FormatProvider
{
	private class Number
	{
		public struct NumberBuffer
		{
			public int precision; //Field offset: 0x0
			public int scale; //Field offset: 0x4
			public bool sign; //Field offset: 0x8
			public Char* overrideDigits; //Field offset: 0x10

			public Char* digits
			{
				 get { } //Length: 5
			}

			public Char* get_digits() { }

		}

		private static String[] s_posCurrencyFormats; //Field offset: 0x0
		private static String[] s_negCurrencyFormats; //Field offset: 0x8
		private static String[] s_posPercentFormats; //Field offset: 0x10
		private static String[] s_negPercentFormats; //Field offset: 0x18
		private static String[] s_negNumberFormats; //Field offset: 0x20
		private static string s_posNumberFormat; //Field offset: 0x28

		private static Number() { }

		private static int FindSection(string format, int section) { }

		private static void FormatCurrency(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

		private static void FormatFixed(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Int32[] groupDigits, string sDecimal, string sGroup) { }

		private static void FormatGeneral(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

		private static void FormatNumber(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatPercent(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

		private static void FormatScientific(StringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

		internal static void Int32ToDecChars(Char* buffer, ref int index, uint value, int digits) { }

		private static bool IsWhite(char ch) { }

		private static Char* MatchChars(Char* p, Char* str) { }

		private static Char* MatchChars(Char* p, string str) { }

		internal static string NumberToString(NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

		internal static string NumberToStringFormat(NumberBuffer number, string format, NumberFormatInfo info) { }

		internal static char ParseFormatSpecifier(string format, out int digits) { }

		private static bool ParseNumber(ref Char* str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		private static void RoundNumber(ref NumberBuffer number, int pos) { }

		private static bool TrailingZeros(ReadOnlySpan<Char> s, int index) { }

		internal static bool TryStringToNumber(ReadOnlySpan<Char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

		private static int wcslen(Char* s) { }

	}


	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	internal static bool TryStringToBigInteger(ReadOnlySpan<Char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}


namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class StringUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Func<TSource, String> valueSelector; //Field offset: 0x0
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public string testValue; //Field offset: 0x0

		public <>c__DisplayClass14_0`1() { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

		[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

	}


	public static StringWriter CreateStringWriter(int capacity) { }

	[Extension]
	public static bool EndsWith(string source, char value) { }

	[Extension]
	public static TSource ForgivingCaseSensitiveFind(IEnumerable<TSource> source, Func<TSource, String> valueSelector, string testValue) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[Extension]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	private static string FormatWith(string format, IFormatProvider provider, Object[] args) { }

	public static bool IsHighSurrogate(char c) { }

	public static bool IsLowSurrogate(char c) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	public static bool StartsWith(string source, char value) { }

	public static string ToCamelCase(string s) { }

	public static void ToCharAsUnicode(char c, Char[] buffer) { }

	private static char ToLower(char c) { }

	[Extension]
	public static string Trim(string s, int start, int length) { }

}


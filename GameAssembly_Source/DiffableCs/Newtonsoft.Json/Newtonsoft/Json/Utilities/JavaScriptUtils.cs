namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class JavaScriptUtils
{
	internal static readonly Boolean[] SingleQuoteCharEscapeFlags; //Field offset: 0x0
	internal static readonly Boolean[] DoubleQuoteCharEscapeFlags; //Field offset: 0x8
	internal static readonly Boolean[] HtmlCharEscapeFlags; //Field offset: 0x10

	private static JavaScriptUtils() { }

	private static int FirstCharToEscape(string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	public static Boolean[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	public static bool ShouldEscapeJavaScriptString(string s, Boolean[] charEscapeFlags) { }

	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<Int64>& integer, out string errorMessage) { }

	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<Char> bufferPool, ref Char[] writeBuffer) { }

}


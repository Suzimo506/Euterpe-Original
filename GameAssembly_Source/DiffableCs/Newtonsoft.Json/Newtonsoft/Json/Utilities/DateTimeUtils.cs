namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class DateTimeUtils
{
	internal static readonly long InitialJavaScriptDateTicks; //Field offset: 0x0
	private static readonly Int32[] DaysToMonth365; //Field offset: 0x8
	private static readonly Int32[] DaysToMonth366; //Field offset: 0x10

	private static DateTimeUtils() { }

	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

	[Extension]
	public static TimeSpan GetUtcOffset(DateTime d) { }

	private static DateTime SwitchToLocalTime(DateTime value) { }

	private static DateTime SwitchToUtcTime(DateTime value) { }

	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

}


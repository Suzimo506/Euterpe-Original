namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	public static readonly string True; //Field offset: 0x8
	public static readonly string False; //Field offset: 0x10
	public static readonly string Null; //Field offset: 0x18
	public static readonly string Undefined; //Field offset: 0x20
	public static readonly string PositiveInfinity; //Field offset: 0x28
	public static readonly string NegativeInfinity; //Field offset: 0x30
	public static readonly string NaN; //Field offset: 0x38

	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[CompilerGenerated]
		 get { } //Length: 86
	}

	private static JsonConvert() { }

	[DebuggerStepThrough]
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static T DeserializeObject(string value) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureDecimalPlace(string text) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CompilerGenerated]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	public static string ToString(string value) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(char value) { }

	public static string ToString(bool value) { }

	public static string ToString(decimal value) { }

	public static string ToString(string value, char delimiter) { }

}


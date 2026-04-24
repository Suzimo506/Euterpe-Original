namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonSerializationException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly string <Path>k__BackingField; //Field offset: 0x90

	public JsonSerializationException() { }

	public JsonSerializationException(string message) { }

	public JsonSerializationException(string message, Exception innerException) { }

	public JsonSerializationException(SerializationInfo info, StreamingContext context) { }

	public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}


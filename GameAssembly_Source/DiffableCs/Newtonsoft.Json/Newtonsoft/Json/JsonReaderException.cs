namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonReaderException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly string <Path>k__BackingField; //Field offset: 0x90

	public JsonReaderException() { }

	public JsonReaderException(SerializationInfo info, StreamingContext context) { }

	public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	internal static JsonReaderException Create(JsonReader reader, string message) { }

	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}


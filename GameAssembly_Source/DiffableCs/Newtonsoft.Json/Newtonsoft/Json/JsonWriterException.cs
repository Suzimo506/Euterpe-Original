namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonWriterException : JsonException
{
	[CompilerGenerated]
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly string <Path>k__BackingField; //Field offset: 0x88

	public JsonWriterException() { }

	public JsonWriterException(SerializationInfo info, StreamingContext context) { }

	public JsonWriterException(string message, string path, Exception innerException) { }

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}


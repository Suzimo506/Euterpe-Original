namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BinaryConverter : JsonConverter
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static ReflectionObject _reflectionObject; //Field offset: 0x681B0

	public BinaryConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static void EnsureReflectionObject(Type t) { }

	private Byte[] GetByteArray(object value) { }

	private Byte[] ReadByteArray(JsonReader reader) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


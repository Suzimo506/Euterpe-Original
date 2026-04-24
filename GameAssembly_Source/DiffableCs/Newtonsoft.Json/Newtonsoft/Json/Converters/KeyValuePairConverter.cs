namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class KeyValuePairConverter : JsonConverter
{
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; //Field offset: 0x2C927B4

	private static KeyValuePairConverter() { }

	public KeyValuePairConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static ReflectionObject InitializeReflectionObject(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


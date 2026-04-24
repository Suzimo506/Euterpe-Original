namespace Newtonsoft.Json.Converters;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EntityKeyMemberConverter : JsonConverter
{
	[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static ReflectionObject _reflectionObject; //Field offset: 0x681E1

	public EntityKeyMemberConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static void EnsureReflectionObject(Type objectType) { }

	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


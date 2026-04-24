namespace Newtonsoft.Json;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class JsonConverter
{

	public override bool CanRead
	{
		 get { } //Length: 3
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	protected JsonConverter() { }

	public abstract bool CanConvert(Type objectType) { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


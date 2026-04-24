namespace Newtonsoft.Json.Converters;

[Obsolete]
public class BsonObjectIdConverter : JsonConverter
{

	public BsonObjectIdConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


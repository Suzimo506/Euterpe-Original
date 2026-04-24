namespace Assets.Scripts.PeroTools.Nice.Variables;

public class DictionaryJsonConverter : JsonConverter
{

	public DictionaryJsonConverter() { }

	public virtual bool CanConvert(Type type) { }

	public virtual object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


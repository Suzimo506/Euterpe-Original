namespace Assets.Scripts.PeroTools.Nice.Variables;

public class DataJsonConverter : CustomCreationConverter<IData>
{

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public DataJsonConverter() { }

	public virtual IData Create(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


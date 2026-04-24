namespace PeroTools2.Datas;

public class ValueJsonConverter : CustomCreationConverter<IValue>
{

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public ValueJsonConverter() { }

	public virtual IValue Create(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


namespace PeroTools2.Datas;

public class DictionaryJsonConverter : CustomCreationConverter<Dictionary`2<String, IVariable>>
{

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public DictionaryJsonConverter() { }

	public virtual Dictionary<String, IVariable> Create(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


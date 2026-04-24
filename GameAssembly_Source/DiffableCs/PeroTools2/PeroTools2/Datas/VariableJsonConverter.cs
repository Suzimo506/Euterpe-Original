namespace PeroTools2.Datas;

public class VariableJsonConverter : CustomCreationConverter<IVariable>
{

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public VariableJsonConverter() { }

	public virtual IVariable Create(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}


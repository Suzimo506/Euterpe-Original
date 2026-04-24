namespace Sirenix.Serialization;

public interface IFormatter
{

	public Type SerializedType
	{
		 get { } //Length: 0
	}

	public object Deserialize(IDataReader reader) { }

	public Type get_SerializedType() { }

	public void Serialize(object value, IDataWriter writer) { }

}


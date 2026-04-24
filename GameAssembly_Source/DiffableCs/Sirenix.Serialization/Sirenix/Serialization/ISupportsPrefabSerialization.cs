namespace Sirenix.Serialization;

public interface ISupportsPrefabSerialization
{

	public SerializationData SerializationData
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public SerializationData get_SerializationData() { }

	public void set_SerializationData(SerializationData value) { }

}


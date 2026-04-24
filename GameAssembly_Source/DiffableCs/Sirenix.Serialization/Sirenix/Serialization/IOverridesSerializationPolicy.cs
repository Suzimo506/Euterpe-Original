namespace Sirenix.Serialization;

public interface IOverridesSerializationPolicy
{

	public bool OdinSerializesUnityFields
	{
		 get { } //Length: 0
	}

	public ISerializationPolicy SerializationPolicy
	{
		 get { } //Length: 0
	}

	public bool get_OdinSerializesUnityFields() { }

	public ISerializationPolicy get_SerializationPolicy() { }

}


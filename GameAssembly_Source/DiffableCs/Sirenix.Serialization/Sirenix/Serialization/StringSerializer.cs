namespace Sirenix.Serialization;

public sealed class StringSerializer : Serializer<String>
{

	public StringSerializer() { }

	public virtual string ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, string value, IDataWriter writer) { }

}


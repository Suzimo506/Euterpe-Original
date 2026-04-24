namespace Sirenix.Serialization;

public sealed class GuidSerializer : Serializer<Guid>
{

	public GuidSerializer() { }

	public virtual Guid ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, Guid value, IDataWriter writer) { }

}


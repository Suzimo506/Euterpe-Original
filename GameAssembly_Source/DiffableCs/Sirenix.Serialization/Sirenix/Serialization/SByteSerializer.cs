namespace Sirenix.Serialization;

public sealed class SByteSerializer : Serializer<SByte>
{

	public SByteSerializer() { }

	public virtual sbyte ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, sbyte value, IDataWriter writer) { }

}


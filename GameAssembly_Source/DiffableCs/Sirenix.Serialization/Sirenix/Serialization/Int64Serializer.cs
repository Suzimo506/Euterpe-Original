namespace Sirenix.Serialization;

public sealed class Int64Serializer : Serializer<Int64>
{

	public Int64Serializer() { }

	public virtual long ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, long value, IDataWriter writer) { }

}


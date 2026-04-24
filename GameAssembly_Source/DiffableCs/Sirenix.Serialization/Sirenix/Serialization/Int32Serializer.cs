namespace Sirenix.Serialization;

public sealed class Int32Serializer : Serializer<Int32>
{

	public Int32Serializer() { }

	public virtual int ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, int value, IDataWriter writer) { }

}


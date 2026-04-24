namespace Sirenix.Serialization;

public sealed class UInt32Serializer : Serializer<UInt32>
{

	public UInt32Serializer() { }

	public virtual uint ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, uint value, IDataWriter writer) { }

}


namespace Sirenix.Serialization;

public sealed class SingleSerializer : Serializer<Single>
{

	public SingleSerializer() { }

	public virtual float ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, float value, IDataWriter writer) { }

}


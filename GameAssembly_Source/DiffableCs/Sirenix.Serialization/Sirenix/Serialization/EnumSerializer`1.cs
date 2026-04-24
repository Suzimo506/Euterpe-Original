namespace Sirenix.Serialization;

public sealed class EnumSerializer : Serializer<T>
{

	private static EnumSerializer`1() { }

	public EnumSerializer`1() { }

	public virtual T ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, T value, IDataWriter writer) { }

}


namespace Sirenix.Serialization;

public sealed class ArrayFormatter : BaseFormatter<T[]>
{
	private static Serializer<T> valueReaderWriter; //Field offset: 0x0

	private static ArrayFormatter`1() { }

	public ArrayFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T[] value, IDataReader reader) { }

	protected virtual T[] GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref T[] value, IDataWriter writer) { }

}


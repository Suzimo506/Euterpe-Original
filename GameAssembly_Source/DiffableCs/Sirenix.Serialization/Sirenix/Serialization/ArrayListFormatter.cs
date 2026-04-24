namespace Sirenix.Serialization;

public class ArrayListFormatter : BaseFormatter<ArrayList>
{
	private static readonly Serializer<Object> ObjectSerializer; //Field offset: 0x2C927B4

	private static ArrayListFormatter() { }

	public ArrayListFormatter() { }

	protected virtual void DeserializeImplementation(ref ArrayList value, IDataReader reader) { }

	protected virtual ArrayList GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref ArrayList value, IDataWriter writer) { }

}


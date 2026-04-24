namespace Sirenix.Serialization;

public class ListFormatter : BaseFormatter<List`1<T>>
{
	private static readonly Serializer<T> TSerializer; //Field offset: 0x0

	private static ListFormatter`1() { }

	public ListFormatter`1() { }

	protected virtual void DeserializeImplementation(ref List<T>& value, IDataReader reader) { }

	protected virtual List<T> GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref List<T>& value, IDataWriter writer) { }

}


namespace Sirenix.Serialization;

public class HashSetFormatter : BaseFormatter<HashSet`1<T>>
{
	private static readonly Serializer<T> TSerializer; //Field offset: 0x0

	private static HashSetFormatter`1() { }

	public HashSetFormatter`1() { }

	protected virtual void DeserializeImplementation(ref HashSet<T>& value, IDataReader reader) { }

	protected virtual HashSet<T> GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref HashSet<T>& value, IDataWriter writer) { }

}


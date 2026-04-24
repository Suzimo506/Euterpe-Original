namespace Sirenix.Serialization;

public class QueueFormatter : BaseFormatter<TQueue>
{
	private static readonly Serializer<TValue> TSerializer; //Field offset: 0x0
	private static readonly bool IsPlainQueue; //Field offset: 0x0

	private static QueueFormatter`2() { }

	public QueueFormatter`2() { }

	protected virtual void DeserializeImplementation(ref TQueue value, IDataReader reader) { }

	protected virtual TQueue GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref TQueue value, IDataWriter writer) { }

}


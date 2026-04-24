namespace Sirenix.Serialization;

public sealed class KeyValuePairFormatter : BaseFormatter<KeyValuePair`2<TKey, TValue>>
{
	private static readonly Serializer<TKey> KeySerializer; //Field offset: 0x0
	private static readonly Serializer<TValue> ValueSerializer; //Field offset: 0x0

	private static KeyValuePairFormatter`2() { }

	public KeyValuePairFormatter`2() { }

	protected virtual void DeserializeImplementation(ref KeyValuePair<TKey, TValue>& value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref KeyValuePair<TKey, TValue>& value, IDataWriter writer) { }

}


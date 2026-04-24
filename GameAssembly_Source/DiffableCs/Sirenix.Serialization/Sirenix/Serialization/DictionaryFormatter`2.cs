namespace Sirenix.Serialization;

public sealed class DictionaryFormatter : BaseFormatter<Dictionary`2<TKey, TValue>>
{
	private static readonly bool KeyIsValueType; //Field offset: 0x0
	private static readonly Serializer<IEqualityComparer`1<TKey>> EqualityComparerSerializer; //Field offset: 0x0
	private static readonly Serializer<TKey> KeyReaderWriter; //Field offset: 0x0
	private static readonly Serializer<TValue> ValueReaderWriter; //Field offset: 0x0

	private static DictionaryFormatter`2() { }

	public DictionaryFormatter`2() { }

	protected virtual void DeserializeImplementation(ref Dictionary<TKey, TValue>& value, IDataReader reader) { }

	protected virtual Dictionary<TKey, TValue> GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref Dictionary<TKey, TValue>& value, IDataWriter writer) { }

}


namespace Sirenix.Serialization;

internal sealed class DoubleLookupDictionaryFormatter : BaseFormatter<DoubleLookupDictionary`3<TPrimary, TSecondary, TValue>>
{
	private static readonly Serializer<TPrimary> PrimaryReaderWriter; //Field offset: 0x0
	private static readonly Serializer<Dictionary`2<TSecondary, TValue>> InnerReaderWriter; //Field offset: 0x0

	private static DoubleLookupDictionaryFormatter`3() { }

	public DoubleLookupDictionaryFormatter`3() { }

	protected virtual void DeserializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue>& value, IDataReader reader) { }

	protected virtual DoubleLookupDictionary<TPrimary, TSecondary, TValue> GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue>& value, IDataWriter writer) { }

}


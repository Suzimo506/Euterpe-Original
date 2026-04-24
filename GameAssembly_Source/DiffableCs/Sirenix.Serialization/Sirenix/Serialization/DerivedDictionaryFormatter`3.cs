namespace Sirenix.Serialization;

internal sealed class DerivedDictionaryFormatter : BaseFormatter<TDictionary>
{
	private static readonly bool KeyIsValueType; //Field offset: 0x0
	private static readonly Serializer<IEqualityComparer`1<TKey>> EqualityComparerSerializer; //Field offset: 0x0
	private static readonly Serializer<TKey> KeyReaderWriter; //Field offset: 0x0
	private static readonly Serializer<TValue> ValueReaderWriter; //Field offset: 0x0
	private static readonly ConstructorInfo ComparerConstructor; //Field offset: 0x0

	private static DerivedDictionaryFormatter`3() { }

	public DerivedDictionaryFormatter`3() { }

	protected virtual void DeserializeImplementation(ref TDictionary value, IDataReader reader) { }

	protected virtual TDictionary GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref TDictionary value, IDataWriter writer) { }

}


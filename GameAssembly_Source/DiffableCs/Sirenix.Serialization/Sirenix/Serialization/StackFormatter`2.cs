namespace Sirenix.Serialization;

public class StackFormatter : BaseFormatter<TStack>
{
	private static readonly Serializer<TValue> TSerializer; //Field offset: 0x0
	private static readonly bool IsPlainStack; //Field offset: 0x0

	private static StackFormatter`2() { }

	public StackFormatter`2() { }

	protected virtual void DeserializeImplementation(ref TStack value, IDataReader reader) { }

	protected virtual TStack GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref TStack value, IDataWriter writer) { }

}


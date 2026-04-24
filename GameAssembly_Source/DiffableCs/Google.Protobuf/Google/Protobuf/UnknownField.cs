namespace Google.Protobuf;

internal sealed class UnknownField
{
	private List<UInt64> varintList; //Field offset: 0x10
	private List<UInt32> fixed32List; //Field offset: 0x18
	private List<UInt64> fixed64List; //Field offset: 0x20
	private List<ByteString> lengthDelimitedList; //Field offset: 0x28
	private List<UnknownFieldSet> groupList; //Field offset: 0x30

	public UnknownField() { }

	private static List<T> Add(List<T> list, T value) { }

	private static List<T> AddAll(List<T> current, IList<T> extras) { }

	internal UnknownField AddFixed32(uint value) { }

	internal UnknownField AddFixed64(ulong value) { }

	internal UnknownField AddGroup(UnknownFieldSet value) { }

	internal UnknownField AddLengthDelimited(ByteString value) { }

	internal UnknownField AddVarint(ulong value) { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	internal int GetSerializedSize(int fieldNumber) { }

	internal UnknownField MergeFrom(UnknownField other) { }

	internal void WriteTo(int fieldNumber, ref WriteContext output) { }

}


namespace Google.Protobuf;

public sealed class UnknownFieldSet
{
	private readonly IDictionary<Int32, UnknownField> fields; //Field offset: 0x10
	private int lastFieldNumber; //Field offset: 0x18
	private UnknownField lastField; //Field offset: 0x20

	internal UnknownFieldSet() { }

	internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field) { }

	public int CalculateSize() { }

	public static UnknownFieldSet Clone(UnknownFieldSet other) { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	private UnknownField GetOrAddField(int number) { }

	internal bool HasField(int field) { }

	private UnknownFieldSet MergeField(int number, UnknownField field) { }

	private bool MergeFieldFrom(ref ParseContext ctx) { }

	public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx) { }

	private UnknownFieldSet MergeFrom(UnknownFieldSet other) { }

	public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other) { }

	internal void MergeGroupFrom(ref ParseContext ctx) { }

	public void WriteTo(ref WriteContext ctx) { }

}


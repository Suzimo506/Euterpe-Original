namespace Google.Protobuf;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ByteString : IEnumerable<Byte>, IEnumerable, IEquatable<ByteString>
{
	private static readonly ByteString empty; //Field offset: 0x0
	private readonly ReadOnlyMemory<Byte> bytes; //Field offset: 0x10

	public static ByteString Empty
	{
		 get { } //Length: 182
	}

	public int Length
	{
		 get { } //Length: 57
	}

	public ReadOnlySpan<Byte> Span
	{
		 get { } //Length: 97
	}

	private static ByteString() { }

	private ByteString(ReadOnlyMemory<Byte> bytes) { }

	internal static ByteString AttachBytes(ReadOnlyMemory<Byte> bytes) { }

	internal static ByteString AttachBytes(Byte[] bytes) { }

	public static ByteString CopyFrom(Byte[] bytes) { }

	public CodedInputStream CreateCodedInput() { }

	public override bool Equals(ByteString other) { }

	public virtual bool Equals(object obj) { }

	public static ByteString get_Empty() { }

	public int get_Length() { }

	public ReadOnlySpan<Byte> get_Span() { }

	public override IEnumerator<Byte> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ByteString lhs, ByteString rhs) { }

	public static bool op_Inequality(ByteString lhs, ByteString rhs) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public string ToBase64() { }

}


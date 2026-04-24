namespace Google.Protobuf.WellKnownTypes;

public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927FC

		private static <>c() { }

		public <>c() { }

		internal Any <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<Any> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string typeUrl_; //Field offset: 0x18
	private ByteString value_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public static MessageParser<Any> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	[DebuggerNonUserCode]
	public string TypeUrl
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public ByteString Value
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	private static Any() { }

	[DebuggerNonUserCode]
	public Any() { }

	[DebuggerNonUserCode]
	public Any(Any other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Any Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Any other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<Any> get_Parser() { }

	public string get_TypeUrl() { }

	public ByteString get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	public static string GetTypeName(string typeUrl) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Any other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_TypeUrl(string value) { }

	public void set_Value(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


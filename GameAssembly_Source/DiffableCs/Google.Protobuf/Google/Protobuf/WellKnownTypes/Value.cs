namespace Google.Protobuf.WellKnownTypes;

public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A58C

		private static <>c() { }

		public <>c() { }

		internal Value <.cctor>b__58_0() { }

	}

	internal enum KindOneofCase
	{
		None = 0,
		NullValue = 1,
		NumberValue = 2,
		StringValue = 3,
		BoolValue = 4,
		StructValue = 5,
		ListValue = 6,
	}

	private static readonly MessageParser<Value> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private object kind_; //Field offset: 0x18
	private KindOneofCase kindCase_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public bool BoolValue
	{
		 get { } //Length: 107
		 set { } //Length: 98
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public KindOneofCase KindCase
	{
		 get { } //Length: 4
	}

	[DebuggerNonUserCode]
	public ListValue ListValue
	{
		 get { } //Length: 83
		 set { } //Length: 51
	}

	[DebuggerNonUserCode]
	public NullValue NullValue
	{
		 get { } //Length: 106
		 set { } //Length: 96
	}

	[DebuggerNonUserCode]
	public double NumberValue
	{
		 get { } //Length: 109
		 set { } //Length: 100
	}

	[DebuggerNonUserCode]
	public static MessageParser<Value> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public string StringValue
	{
		 get { } //Length: 92
		 set { } //Length: 98
	}

	[DebuggerNonUserCode]
	public Struct StructValue
	{
		 get { } //Length: 83
		 set { } //Length: 51
	}

	private static Value() { }

	[DebuggerNonUserCode]
	public Value() { }

	[DebuggerNonUserCode]
	public Value(Value other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_BoolValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public KindOneofCase get_KindCase() { }

	public ListValue get_ListValue() { }

	public NullValue get_NullValue() { }

	public double get_NumberValue() { }

	public static MessageParser<Value> get_Parser() { }

	public string get_StringValue() { }

	public Struct get_StructValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Value other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BoolValue(bool value) { }

	public void set_ListValue(ListValue value) { }

	public void set_NullValue(NullValue value) { }

	public void set_NumberValue(double value) { }

	public void set_StringValue(string value) { }

	public void set_StructValue(Struct value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


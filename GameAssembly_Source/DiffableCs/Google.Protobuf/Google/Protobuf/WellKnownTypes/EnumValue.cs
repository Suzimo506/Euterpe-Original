namespace Google.Protobuf.WellKnownTypes;

public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927BC

		private static <>c() { }

		public <>c() { }

		internal EnumValue <.cctor>b__37_0() { }

	}

	private static readonly MessageParser<EnumValue> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private int number_; //Field offset: 0x20
	private readonly RepeatedField<Option> options_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public int Number
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumValue> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static EnumValue() { }

	[DebuggerNonUserCode]
	public EnumValue() { }

	[DebuggerNonUserCode]
	public EnumValue(EnumValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Name() { }

	public int get_Number() { }

	public static MessageParser<EnumValue> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumValue other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


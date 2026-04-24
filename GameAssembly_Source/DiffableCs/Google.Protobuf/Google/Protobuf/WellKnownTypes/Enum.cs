namespace Google.Protobuf.WellKnownTypes;

public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69974

		private static <>c() { }

		public <>c() { }

		internal Enum <.cctor>b__47_0() { }

	}

	private static readonly MessageParser<Enum> _parser; //Field offset: 0x0
	private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; //Field offset: 0x8
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private readonly RepeatedField<EnumValue> enumvalue_; //Field offset: 0x20
	private readonly RepeatedField<Option> options_; //Field offset: 0x28
	private SourceContext sourceContext_; //Field offset: 0x30
	private Syntax syntax_; //Field offset: 0x38

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
	public static MessageParser<Enum> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public SourceContext SourceContext
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public Syntax Syntax
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static Enum() { }

	[DebuggerNonUserCode]
	public Enum() { }

	[DebuggerNonUserCode]
	public Enum(Enum other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Enum Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Enum other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Name() { }

	public static MessageParser<Enum> get_Parser() { }

	public SourceContext get_SourceContext() { }

	public Syntax get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Enum other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_SourceContext(SourceContext value) { }

	public void set_Syntax(Syntax value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


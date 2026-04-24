namespace Google.Protobuf.WellKnownTypes;

public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A5F0

		private static <>c() { }

		public <>c() { }

		internal Type <.cctor>b__52_0() { }

	}

	private static readonly MessageParser<Type> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Field> _repeated_fields_codec; //Field offset: 0x8
	private static readonly FieldCodec<String> _repeated_oneofs_codec; //Field offset: 0x10
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x18
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private readonly RepeatedField<Field> fields_; //Field offset: 0x20
	private readonly RepeatedField<String> oneofs_; //Field offset: 0x28
	private readonly RepeatedField<Option> options_; //Field offset: 0x30
	private SourceContext sourceContext_; //Field offset: 0x38
	private Syntax syntax_; //Field offset: 0x40

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageParser<Type> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
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

	private static Type() { }

	[DebuggerNonUserCode]
	public Type() { }

	[DebuggerNonUserCode]
	public Type(Type other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Type Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Type other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Name() { }

	public static MessageParser<Type> get_Parser() { }

	public SourceContext get_SourceContext() { }

	public Syntax get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Type other) { }

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


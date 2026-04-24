namespace Google.Protobuf.Reflection;

public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IMessage<EnumValueOptions>, IMessage, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927BC

		private static <>c() { }

		public <>c() { }

		internal EnumValueOptions <.cctor>b__47_0() { }

	}

	private static readonly MessageParser<EnumValueOptions> _parser; //Field offset: 0x0
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<EnumValueOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private bool deprecated_; //Field offset: 0x24
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumValueOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static EnumValueOptions() { }

	[DebuggerNonUserCode]
	public EnumValueOptions() { }

	[DebuggerNonUserCode]
	public EnumValueOptions(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumValueOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public static MessageParser<EnumValueOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Deprecated(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


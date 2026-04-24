namespace Google.Protobuf.Reflection;

public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69BBD

		private static <>c() { }

		public <>c() { }

		internal MessageOptions <.cctor>b__74_0() { }

	}

	private static readonly MessageParser<MessageOptions> _parser; //Field offset: 0x0
	private static readonly bool MessageSetWireFormatDefaultValue; //Field offset: 0x8
	private static readonly bool NoStandardDescriptorAccessorDefaultValue; //Field offset: 0x9
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0xA
	private static readonly bool MapEntryDefaultValue; //Field offset: 0xB
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<MessageOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private bool messageSetWireFormat_; //Field offset: 0x24
	private bool noStandardDescriptorAccessor_; //Field offset: 0x25
	private bool deprecated_; //Field offset: 0x26
	private bool mapEntry_; //Field offset: 0x27
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
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasMapEntry
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasMessageSetWireFormat
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasNoStandardDescriptorAccessor
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool MapEntry
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool MessageSetWireFormat
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool NoStandardDescriptorAccessor
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageParser<MessageOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static MessageOptions() { }

	[DebuggerNonUserCode]
	public MessageOptions() { }

	[DebuggerNonUserCode]
	public MessageOptions(MessageOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MessageOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MessageOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public bool get_HasMapEntry() { }

	public bool get_HasMessageSetWireFormat() { }

	public bool get_HasNoStandardDescriptorAccessor() { }

	public bool get_MapEntry() { }

	public bool get_MessageSetWireFormat() { }

	public bool get_NoStandardDescriptorAccessor() { }

	public static MessageParser<MessageOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MessageOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Deprecated(bool value) { }

	public void set_MapEntry(bool value) { }

	public void set_MessageSetWireFormat(bool value) { }

	public void set_NoStandardDescriptorAccessor(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


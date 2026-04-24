namespace Google.Protobuf.Reflection;

public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IMessage<ExtensionRangeOptions>, IMessage, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69A9C

		private static <>c() { }

		public <>c() { }

		internal ExtensionRangeOptions <.cctor>b__37_0() { }

	}

	private static readonly MessageParser<ExtensionRangeOptions> _parser; //Field offset: 0x0
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<ExtensionRangeOptions> _extensions; //Field offset: 0x18
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public static MessageParser<ExtensionRangeOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static ExtensionRangeOptions() { }

	[DebuggerNonUserCode]
	public ExtensionRangeOptions() { }

	[DebuggerNonUserCode]
	public ExtensionRangeOptions(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExtensionRangeOptions Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(ExtensionRangeOptions other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<ExtensionRangeOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


namespace Google.Protobuf.Reflection;

public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69C1E

		private static <>c() { }

		public <>c() { }

		internal EnumOptions <.cctor>b__56_0() { }

	}

	private static readonly MessageParser<EnumOptions> _parser; //Field offset: 0x0
	private static readonly bool AllowAliasDefaultValue; //Field offset: 0x8
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x9
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<EnumOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private bool allowAlias_; //Field offset: 0x24
	private bool deprecated_; //Field offset: 0x25
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public bool AllowAlias
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

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
	public bool HasAllowAlias
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static EnumOptions() { }

	[DebuggerNonUserCode]
	public EnumOptions() { }

	[DebuggerNonUserCode]
	public EnumOptions(EnumOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_AllowAlias() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasAllowAlias() { }

	public bool get_HasDeprecated() { }

	public static MessageParser<EnumOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AllowAlias(bool value) { }

	public void set_Deprecated(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


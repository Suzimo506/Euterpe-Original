namespace Google.Protobuf.Reflection;

public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69C20

		private static <>c() { }

		public <>c() { }

		internal ServiceOptions <.cctor>b__47_0() { }

	}

	private static readonly MessageParser<ServiceOptions> _parser; //Field offset: 0x0
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<ServiceOptions> _extensions; //Field offset: 0x18
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
	public static MessageParser<ServiceOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static ServiceOptions() { }

	[DebuggerNonUserCode]
	public ServiceOptions() { }

	[DebuggerNonUserCode]
	public ServiceOptions(ServiceOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ServiceOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ServiceOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public static MessageParser<ServiceOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ServiceOptions other) { }

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


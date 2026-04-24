namespace Google.Protobuf.Reflection;

public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69C5C

		private static <>c() { }

		public <>c() { }

		internal MethodOptions <.cctor>b__57_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum IdempotencyLevel
		{
			IdempotencyUnknown = 0,
			NoSideEffects = 1,
			Idempotent = 2,
		}


	}

	private static readonly MessageParser<MethodOptions> _parser; //Field offset: 0x0
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x8
	private static readonly IdempotencyLevel IdempotencyLevelDefaultValue; //Field offset: 0xC
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<MethodOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private bool deprecated_; //Field offset: 0x24
	private IdempotencyLevel idempotencyLevel_; //Field offset: 0x28
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x30

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
	public bool HasIdempotencyLevel
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public IdempotencyLevel IdempotencyLevel
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageParser<MethodOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static MethodOptions() { }

	[DebuggerNonUserCode]
	public MethodOptions() { }

	[DebuggerNonUserCode]
	public MethodOptions(MethodOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MethodOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MethodOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasDeprecated() { }

	public bool get_HasIdempotencyLevel() { }

	public IdempotencyLevel get_IdempotencyLevel() { }

	public static MessageParser<MethodOptions> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MethodOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Deprecated(bool value) { }

	public void set_IdempotencyLevel(IdempotencyLevel value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


namespace Google.Protobuf.WellKnownTypes;

public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A560

		private static <>c() { }

		public <>c() { }

		internal Struct <.cctor>b__27_0() { }

	}

	private static readonly MessageParser<Struct> _parser; //Field offset: 0x0
	private static readonly Codec<String, Value> _map_fields_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private readonly MapField<String, Value> fields_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public MapField<String, Value> Fields
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public static MessageParser<Struct> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	private static Struct() { }

	[DebuggerNonUserCode]
	public Struct() { }

	[DebuggerNonUserCode]
	public Struct(Struct other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Struct Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(Struct other) { }

	public static MessageDescriptor get_Descriptor() { }

	public MapField<String, Value> get_Fields() { }

	public static MessageParser<Struct> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Struct other) { }

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


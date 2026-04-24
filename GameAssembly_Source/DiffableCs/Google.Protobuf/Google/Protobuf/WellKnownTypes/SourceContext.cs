namespace Google.Protobuf.WellKnownTypes;

public sealed class SourceContext : IMessage<SourceContext>, IMessage, IEquatable<SourceContext>, IDeepCloneable<SourceContext>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A55C

		private static <>c() { }

		public <>c() { }

		internal SourceContext <.cctor>b__27_0() { }

	}

	private static readonly MessageParser<SourceContext> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string fileName_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public string FileName
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageParser<SourceContext> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	private static SourceContext() { }

	[DebuggerNonUserCode]
	public SourceContext() { }

	[DebuggerNonUserCode]
	public SourceContext(SourceContext other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SourceContext Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(SourceContext other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_FileName() { }

	public static MessageParser<SourceContext> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SourceContext other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_FileName(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


namespace Google.Protobuf.WellKnownTypes;

public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, IBufferMessage, ICustomDiagnosticMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A526

		private static <>c() { }

		public <>c() { }

		internal Duration <.cctor>b__48_0() { }

	}

	private static readonly MessageParser<Duration> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private long seconds_; //Field offset: 0x18
	private int nanos_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public int Nanos
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public static MessageParser<Duration> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	[DebuggerNonUserCode]
	public long Seconds
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	private static Duration() { }

	[DebuggerNonUserCode]
	public Duration() { }

	[DebuggerNonUserCode]
	public Duration(Duration other) { }

	internal static void AppendNanoseconds(StringBuilder builder, int nanos) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Duration Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Duration other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Nanos() { }

	public static MessageParser<Duration> get_Parser() { }

	public long get_Seconds() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	internal static bool IsNormalized(long seconds, int nanoseconds) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Duration other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Nanos(int value) { }

	public void set_Seconds(long value) { }

	public override string ToDiagnosticString() { }

	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


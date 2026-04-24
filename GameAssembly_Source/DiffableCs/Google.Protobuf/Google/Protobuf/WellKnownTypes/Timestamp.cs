namespace Google.Protobuf.WellKnownTypes;

public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Timestamp>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6A5ED

		private static <>c() { }

		public <>c() { }

		internal Timestamp <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<Timestamp> _parser; //Field offset: 0x0
	private static readonly DateTime UnixEpoch; //Field offset: 0x8
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
	public static MessageParser<Timestamp> Parser
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

	private static Timestamp() { }

	[DebuggerNonUserCode]
	public Timestamp() { }

	[DebuggerNonUserCode]
	public Timestamp(Timestamp other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Timestamp Clone() { }

	public override int CompareTo(Timestamp other) { }

	[DebuggerNonUserCode]
	public override bool Equals(Timestamp other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Nanos() { }

	public static MessageParser<Timestamp> get_Parser() { }

	public long get_Seconds() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	private static bool IsNormalized(long seconds, int nanoseconds) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Timestamp other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	public static bool op_Equality(Timestamp a, Timestamp b) { }

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


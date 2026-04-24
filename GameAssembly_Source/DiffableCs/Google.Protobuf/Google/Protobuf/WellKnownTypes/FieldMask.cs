namespace Google.Protobuf.WellKnownTypes;

public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, IBufferMessage, ICustomDiagnosticMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal FieldMask <.cctor>b__47_0() { }

		internal bool <ToJson>b__29_0(string p) { }

	}

	private static readonly MessageParser<FieldMask> _parser; //Field offset: 0x0
	private static readonly FieldCodec<String> _repeated_paths_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private readonly RepeatedField<String> paths_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public static MessageParser<FieldMask> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	public RepeatedField<String> Paths
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	private static FieldMask() { }

	[DebuggerNonUserCode]
	public FieldMask() { }

	[DebuggerNonUserCode]
	public FieldMask(FieldMask other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FieldMask Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FieldMask other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<FieldMask> get_Parser() { }

	public RepeatedField<String> get_Paths() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	private static bool IsPathValid(string input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FieldMask other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public override string ToDiagnosticString() { }

	internal static string ToJson(IList<String> paths, bool diagnosticOnly) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


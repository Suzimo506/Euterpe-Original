namespace Google.Protobuf.Reflection;

public sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IMessage, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927BC

		private static <>c() { }

		public <>c() { }

		internal FileDescriptorSet <.cctor>b__27_0() { }

	}

	private static readonly MessageParser<FileDescriptorSet> _parser; //Field offset: 0x0
	private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private readonly RepeatedField<FileDescriptorProto> file_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public static MessageParser<FileDescriptorSet> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	private static FileDescriptorSet() { }

	[DebuggerNonUserCode]
	public FileDescriptorSet() { }

	[DebuggerNonUserCode]
	public FileDescriptorSet(FileDescriptorSet other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FileDescriptorSet Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(FileDescriptorSet other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<FileDescriptorSet> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FileDescriptorSet other) { }

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


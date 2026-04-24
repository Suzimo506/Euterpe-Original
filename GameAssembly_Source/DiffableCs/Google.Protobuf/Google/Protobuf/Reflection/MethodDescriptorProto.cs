namespace Google.Protobuf.Reflection;

public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927B4

		private static <>c() { }

		public <>c() { }

		internal MethodDescriptorProto <.cctor>b__73_0() { }

	}

	private static readonly MessageParser<MethodDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly string InputTypeDefaultValue; //Field offset: 0x10
	private static readonly string OutputTypeDefaultValue; //Field offset: 0x18
	private static readonly bool ClientStreamingDefaultValue; //Field offset: 0x20
	private static readonly bool ServerStreamingDefaultValue; //Field offset: 0x21
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private int _hasBits0; //Field offset: 0x18
	private string name_; //Field offset: 0x20
	private string inputType_; //Field offset: 0x28
	private string outputType_; //Field offset: 0x30
	private MethodOptions options_; //Field offset: 0x38
	private bool clientStreaming_; //Field offset: 0x40
	private bool serverStreaming_; //Field offset: 0x41

	[DebuggerNonUserCode]
	public bool ClientStreaming
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
	public bool HasClientStreaming
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasInputType
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasOutputType
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasServerStreaming
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public string InputType
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public MethodOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public string OutputType
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageParser<MethodDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public bool ServerStreaming
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	private static MethodDescriptorProto() { }

	[DebuggerNonUserCode]
	public MethodDescriptorProto() { }

	[DebuggerNonUserCode]
	public MethodDescriptorProto(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MethodDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(MethodDescriptorProto other) { }

	public bool get_ClientStreaming() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasClientStreaming() { }

	public bool get_HasInputType() { }

	public bool get_HasName() { }

	public bool get_HasOutputType() { }

	public bool get_HasServerStreaming() { }

	public string get_InputType() { }

	public string get_Name() { }

	public MethodOptions get_Options() { }

	public string get_OutputType() { }

	public static MessageParser<MethodDescriptorProto> get_Parser() { }

	public bool get_ServerStreaming() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ClientStreaming(bool value) { }

	public void set_InputType(string value) { }

	public void set_Name(string value) { }

	public void set_Options(MethodOptions value) { }

	public void set_OutputType(string value) { }

	public void set_ServerStreaming(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


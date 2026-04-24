namespace Google.Protobuf.Reflection;

public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x699D0

		private static <>c() { }

		public <>c() { }

		internal FileDescriptorProto <.cctor>b__94_0() { }

	}

	private static readonly MessageParser<FileDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly string PackageDefaultValue; //Field offset: 0x10
	private static readonly FieldCodec<String> _repeated_dependency_codec; //Field offset: 0x18
	private static readonly FieldCodec<Int32> _repeated_publicDependency_codec; //Field offset: 0x20
	private static readonly FieldCodec<Int32> _repeated_weakDependency_codec; //Field offset: 0x28
	private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; //Field offset: 0x30
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; //Field offset: 0x38
	private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; //Field offset: 0x40
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; //Field offset: 0x48
	private static readonly string SyntaxDefaultValue; //Field offset: 0x50
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private string package_; //Field offset: 0x20
	private readonly RepeatedField<String> dependency_; //Field offset: 0x28
	private readonly RepeatedField<Int32> publicDependency_; //Field offset: 0x30
	private readonly RepeatedField<Int32> weakDependency_; //Field offset: 0x38
	private readonly RepeatedField<DescriptorProto> messageType_; //Field offset: 0x40
	private readonly RepeatedField<EnumDescriptorProto> enumType_; //Field offset: 0x48
	private readonly RepeatedField<ServiceDescriptorProto> service_; //Field offset: 0x50
	private readonly RepeatedField<FieldDescriptorProto> extension_; //Field offset: 0x58
	private FileOptions options_; //Field offset: 0x60
	private SourceCodeInfo sourceCodeInfo_; //Field offset: 0x68
	private string syntax_; //Field offset: 0x70

	[DebuggerNonUserCode]
	public RepeatedField<String> Dependency
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumDescriptorProto> EnumType
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Extension
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasPackage
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasSyntax
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public RepeatedField<DescriptorProto> MessageType
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public FileOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public string Package
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageParser<FileDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> PublicDependency
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public RepeatedField<ServiceDescriptorProto> Service
	{
		 get { } //Length: 5
	}

	[DebuggerNonUserCode]
	public SourceCodeInfo SourceCodeInfo
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public string Syntax
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	private static FileDescriptorProto() { }

	[DebuggerNonUserCode]
	public FileDescriptorProto() { }

	[DebuggerNonUserCode]
	public FileDescriptorProto(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FileDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<String> get_Dependency() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	public bool get_HasName() { }

	public bool get_HasPackage() { }

	public bool get_HasSyntax() { }

	public RepeatedField<DescriptorProto> get_MessageType() { }

	public string get_Name() { }

	public FileOptions get_Options() { }

	public string get_Package() { }

	public static MessageParser<FileDescriptorProto> get_Parser() { }

	public RepeatedField<Int32> get_PublicDependency() { }

	public RepeatedField<ServiceDescriptorProto> get_Service() { }

	public SourceCodeInfo get_SourceCodeInfo() { }

	public string get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(FileOptions value) { }

	public void set_Package(string value) { }

	public void set_SourceCodeInfo(SourceCodeInfo value) { }

	public void set_Syntax(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


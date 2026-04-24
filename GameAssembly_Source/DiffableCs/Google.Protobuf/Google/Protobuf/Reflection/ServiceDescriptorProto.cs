namespace Google.Protobuf.Reflection;

public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IMessage, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69B68

		private static <>c() { }

		public <>c() { }

		internal ServiceDescriptorProto <.cctor>b__41_0() { }

	}

	private static readonly MessageParser<ServiceDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private readonly RepeatedField<MethodDescriptorProto> method_; //Field offset: 0x20
	private ServiceOptions options_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public RepeatedField<MethodDescriptorProto> Method
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
	public ServiceOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<ServiceDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static ServiceDescriptorProto() { }

	[DebuggerNonUserCode]
	public ServiceDescriptorProto() { }

	[DebuggerNonUserCode]
	public ServiceDescriptorProto(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ServiceDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public RepeatedField<MethodDescriptorProto> get_Method() { }

	public string get_Name() { }

	public ServiceOptions get_Options() { }

	public static MessageParser<ServiceDescriptorProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(ServiceOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


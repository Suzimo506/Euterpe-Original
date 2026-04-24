namespace Google.Protobuf.Reflection;

public sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IMessage, IEquatable<OneofDescriptorProto>, IDeepCloneable<OneofDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69AA0

		private static <>c() { }

		public <>c() { }

		internal OneofDescriptorProto <.cctor>b__36_0() { }

	}

	private static readonly MessageParser<OneofDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private string name_; //Field offset: 0x18
	private OneofOptions options_; //Field offset: 0x20

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
	public string Name
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public OneofOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<OneofDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static OneofDescriptorProto() { }

	[DebuggerNonUserCode]
	public OneofDescriptorProto() { }

	[DebuggerNonUserCode]
	public OneofDescriptorProto(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override OneofDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public string get_Name() { }

	public OneofOptions get_Options() { }

	public static MessageParser<OneofDescriptorProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(OneofOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


namespace Google.Protobuf.Reflection;

public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69B10

		private static <>c() { }

		public <>c() { }

		internal EnumValueDescriptorProto <.cctor>b__46_0() { }

	}

	private static readonly MessageParser<EnumValueDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly int NumberDefaultValue; //Field offset: 0x10
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private int _hasBits0; //Field offset: 0x18
	private string name_; //Field offset: 0x20
	private int number_; //Field offset: 0x28
	private EnumValueOptions options_; //Field offset: 0x30

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
	public bool HasNumber
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public int Number
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public EnumValueOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumValueDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static EnumValueDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumValueDescriptorProto() { }

	[DebuggerNonUserCode]
	public EnumValueDescriptorProto(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumValueDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasName() { }

	public bool get_HasNumber() { }

	public string get_Name() { }

	public int get_Number() { }

	public EnumValueOptions get_Options() { }

	public static MessageParser<EnumValueDescriptorProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	public void set_Options(EnumValueOptions value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


namespace Google.Protobuf.Reflection;

public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927B4

		private static <>c() { }

		public <>c() { }

		internal FieldDescriptorProto <.cctor>b__119_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum Label
		{
			Optional = 1,
			Required = 2,
			Repeated = 3,
		}

		internal enum Type
		{
			Double = 1,
			Float = 2,
			Int64 = 3,
			Uint64 = 4,
			Int32 = 5,
			Fixed64 = 6,
			Fixed32 = 7,
			Bool = 8,
			String = 9,
			Group = 10,
			Message = 11,
			Bytes = 12,
			Uint32 = 13,
			Enum = 14,
			Sfixed32 = 15,
			Sfixed64 = 16,
			Sint32 = 17,
			Sint64 = 18,
		}


	}

	private static readonly MessageParser<FieldDescriptorProto> _parser; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x8
	private static readonly int NumberDefaultValue; //Field offset: 0x10
	private static readonly Label LabelDefaultValue; //Field offset: 0x14
	private static readonly Type TypeDefaultValue; //Field offset: 0x18
	private static readonly string TypeNameDefaultValue; //Field offset: 0x20
	private static readonly string ExtendeeDefaultValue; //Field offset: 0x28
	private static readonly string DefaultValueDefaultValue; //Field offset: 0x30
	private static readonly int OneofIndexDefaultValue; //Field offset: 0x38
	private static readonly string JsonNameDefaultValue; //Field offset: 0x40
	private static readonly bool Proto3OptionalDefaultValue; //Field offset: 0x48
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private int _hasBits0; //Field offset: 0x18
	private string name_; //Field offset: 0x20
	private int number_; //Field offset: 0x28
	private Label label_; //Field offset: 0x2C
	private Type type_; //Field offset: 0x30
	private string typeName_; //Field offset: 0x38
	private string extendee_; //Field offset: 0x40
	private string defaultValue_; //Field offset: 0x48
	private int oneofIndex_; //Field offset: 0x50
	private string jsonName_; //Field offset: 0x58
	private FieldOptions options_; //Field offset: 0x60
	private bool proto3Optional_; //Field offset: 0x68

	[DebuggerNonUserCode]
	public string DefaultValue
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public string Extendee
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public bool HasDefaultValue
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasExtendee
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasJsonName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasLabel
	{
		 get { } //Length: 8
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
	public bool HasOneofIndex
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasProto3Optional
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasType
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasTypeName
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public string JsonName
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public Label Label
	{
		 get { } //Length: 107
		 set { } //Length: 8
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
	public int OneofIndex
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public FieldOptions Options
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[DebuggerNonUserCode]
	public static MessageParser<FieldDescriptorProto> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public bool Proto3Optional
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public Type Type
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public string TypeName
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	private static FieldDescriptorProto() { }

	[DebuggerNonUserCode]
	public FieldDescriptorProto() { }

	[DebuggerNonUserCode]
	public FieldDescriptorProto(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FieldDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public string get_DefaultValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Extendee() { }

	public bool get_HasDefaultValue() { }

	public bool get_HasExtendee() { }

	public bool get_HasJsonName() { }

	public bool get_HasLabel() { }

	public bool get_HasName() { }

	public bool get_HasNumber() { }

	public bool get_HasOneofIndex() { }

	public bool get_HasProto3Optional() { }

	public bool get_HasType() { }

	public bool get_HasTypeName() { }

	public string get_JsonName() { }

	public Label get_Label() { }

	public string get_Name() { }

	public int get_Number() { }

	public int get_OneofIndex() { }

	public FieldOptions get_Options() { }

	public static MessageParser<FieldDescriptorProto> get_Parser() { }

	public bool get_Proto3Optional() { }

	public Type get_Type() { }

	public string get_TypeName() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_DefaultValue(string value) { }

	public void set_Extendee(string value) { }

	public void set_JsonName(string value) { }

	public void set_Label(Label value) { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	public void set_OneofIndex(int value) { }

	public void set_Options(FieldOptions value) { }

	public void set_Proto3Optional(bool value) { }

	public void set_Type(Type value) { }

	public void set_TypeName(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}


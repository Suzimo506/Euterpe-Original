namespace Google.Protobuf.Reflection;

public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
{
	private EnumDescriptor enumType; //Field offset: 0x28
	private MessageDescriptor extendeeType; //Field offset: 0x30
	private MessageDescriptor messageType; //Field offset: 0x38
	private FieldType fieldType; //Field offset: 0x40
	private readonly string propertyName; //Field offset: 0x48
	private IFieldAccessor accessor; //Field offset: 0x50
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly OneofDescriptor <ContainingOneof>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly string <JsonName>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly FieldDescriptorProto <Proto>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly Extension <Extension>k__BackingField; //Field offset: 0x78

	public IFieldAccessor Accessor
	{
		 get { } //Length: 5
	}

	public OneofDescriptor ContainingOneof
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MessageDescriptor ContainingType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MessageDescriptor ExtendeeType
	{
		 get { } //Length: 116
	}

	public Extension Extension
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int FieldNumber
	{
		 get { } //Length: 118
	}

	public FieldType FieldType
	{
		 get { } //Length: 4
	}

	public bool HasPresence
	{
		 get { } //Length: 159
	}

	public bool IsMap
	{
		 get { } //Length: 60
	}

	public bool IsRepeated
	{
		 get { } //Length: 130
	}

	public string JsonName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 113
	}

	internal FieldDescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public OneofDescriptor RealContainingOneof
	{
		 get { } //Length: 18
	}

	internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Extension extension) { }

	public override int CompareTo(FieldDescriptor other) { }

	private IFieldAccessor CreateAccessor() { }

	internal void CrossLink() { }

	public IFieldAccessor get_Accessor() { }

	[CompilerGenerated]
	public OneofDescriptor get_ContainingOneof() { }

	[CompilerGenerated]
	public MessageDescriptor get_ContainingType() { }

	public MessageDescriptor get_ExtendeeType() { }

	[CompilerGenerated]
	public Extension get_Extension() { }

	public int get_FieldNumber() { }

	public FieldType get_FieldType() { }

	public bool get_HasPresence() { }

	public bool get_IsMap() { }

	public bool get_IsRepeated() { }

	[CompilerGenerated]
	public string get_JsonName() { }

	public virtual string get_Name() { }

	[CompilerGenerated]
	internal FieldDescriptorProto get_Proto() { }

	public OneofDescriptor get_RealContainingOneof() { }

	private static FieldType GetFieldTypeFromProtoType(Type type) { }

}


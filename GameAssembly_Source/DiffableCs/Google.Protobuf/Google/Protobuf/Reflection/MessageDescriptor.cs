namespace Google.Protobuf.Reflection;

public sealed class MessageDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldDescriptor, Int32> <>9__5_4; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__5_4(FieldDescriptor field) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public FileDescriptor file; //Field offset: 0x10
		public MessageDescriptor <>4__this; //Field offset: 0x18
		public GeneratedClrTypeInfo generatedCodeInfo; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal OneofDescriptor <.ctor>b__0(OneofDescriptorProto oneof, int index) { }

		internal MessageDescriptor <.ctor>b__1(DescriptorProto type, int index) { }

		internal EnumDescriptor <.ctor>b__2(EnumDescriptorProto type, int index) { }

		internal FieldDescriptor <.ctor>b__3(FieldDescriptorProto field, int index) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class FieldCollection
	{
		private readonly MessageDescriptor messageDescriptor; //Field offset: 0x10

		public FieldDescriptor Item
		{
			 get { } //Length: 150
		}

		internal FieldCollection(MessageDescriptor messageDescriptor) { }

		public FieldDescriptor get_Item(int number) { }

		public IList<FieldDescriptor> InDeclarationOrder() { }

		public IList<FieldDescriptor> InFieldNumberOrder() { }

	}

	private static readonly HashSet<String> WellKnownTypeNames; //Field offset: 0x0
	private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; //Field offset: 0x28
	private readonly IList<FieldDescriptor> fieldsInNumberOrder; //Field offset: 0x30
	private readonly IDictionary<String, FieldDescriptor> jsonFieldMap; //Field offset: 0x38
	[CompilerGenerated]
	private readonly DescriptorProto <Proto>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Type <ClrType>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly MessageParser <Parser>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly FieldCollection <Fields>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly ExtensionCollection <Extensions>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <NestedTypes>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly IList<OneofDescriptor> <Oneofs>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly int <RealOneofCount>k__BackingField; //Field offset: 0x88

	public Type ClrType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IList<EnumDescriptor> EnumTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExtensionCollection Extensions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FieldCollection Fields
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal bool IsWellKnownType
	{
		internal get { } //Length: 198
	}

	internal bool IsWrapperType
	{
		internal get { } //Length: 124
	}

	public virtual string Name
	{
		 get { } //Length: 29
	}

	public IList<MessageDescriptor> NestedTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IList<OneofDescriptor> Oneofs
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public MessageParser Parser
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal DescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static MessageDescriptor() { }

	internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) { }

	private static ReadOnlyDictionary<String, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) { }

	internal void CrossLink() { }

	public FieldDescriptor FindFieldByNumber(int number) { }

	[CompilerGenerated]
	public Type get_ClrType() { }

	[CompilerGenerated]
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	public ExtensionCollection get_Extensions() { }

	[CompilerGenerated]
	public FieldCollection get_Fields() { }

	internal bool get_IsWellKnownType() { }

	internal bool get_IsWrapperType() { }

	public virtual string get_Name() { }

	[CompilerGenerated]
	public IList<MessageDescriptor> get_NestedTypes() { }

	[CompilerGenerated]
	public IList<OneofDescriptor> get_Oneofs() { }

	[CompilerGenerated]
	public MessageParser get_Parser() { }

	[CompilerGenerated]
	internal DescriptorProto get_Proto() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}


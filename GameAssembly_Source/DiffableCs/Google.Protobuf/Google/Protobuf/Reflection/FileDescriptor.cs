namespace Google.Protobuf.Reflection;

public sealed class FileDescriptor : IDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FileDescriptor, String> <>9__9_0; //Field offset: 0x8
		public static Func<GeneratedClrTypeInfo, Boolean> <>9__53_0; //Field offset: 0x10
		public static Func<FieldDescriptor, Extension> <>9__54_0; //Field offset: 0x18
		public static Func<Extension, Boolean> <>9__54_1; //Field offset: 0x20
		public static Func<FieldDescriptor, Extension> <>9__55_0; //Field offset: 0x28
		public static Func<Extension, Boolean> <>9__55_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <DeterminePublicDependencies>b__9_0(FileDescriptor file) { }

		internal Extension <GetAllDependedExtensions>b__54_0(FieldDescriptor s) { }

		internal bool <GetAllDependedExtensions>b__54_1(Extension e) { }

		internal Extension <GetAllDependedExtensionsFromMessage>b__55_0(FieldDescriptor s) { }

		internal bool <GetAllDependedExtensionsFromMessage>b__55_1(Extension e) { }

		internal bool <GetAllGeneratedExtensions>b__53_0(GeneratedClrTypeInfo t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FileDescriptor <>4__this; //Field offset: 0x10
		public GeneratedClrTypeInfo generatedCodeInfo; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal MessageDescriptor <.ctor>b__0(DescriptorProto message, int index) { }

		internal EnumDescriptor <.ctor>b__1(EnumDescriptorProto enumType, int index) { }

		internal ServiceDescriptor <.ctor>b__2(ServiceDescriptorProto service, int index) { }

	}

	private readonly Lazy<Dictionary`2<IDescriptor, DescriptorDeclaration>> declarations; //Field offset: 0x10
	[CompilerGenerated]
	private readonly FileDescriptorProto <Proto>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Syntax <Syntax>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <MessageTypes>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly IList<ServiceDescriptor> <Services>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ExtensionCollection <Extensions>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <Dependencies>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <PublicDependencies>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly ByteString <SerializedData>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly DescriptorPool <DescriptorPool>k__BackingField; //Field offset: 0x60

	public IList<FileDescriptor> Dependencies
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal DescriptorPool DescriptorPool
	{
		[CompilerGenerated]
		internal get { } //Length: 5
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

	private override FileDescriptor Google.Protobuf.Reflection.IDescriptor.File
	{
		private get { } //Length: 4
	}

	private override string Google.Protobuf.Reflection.IDescriptor.FullName
	{
		private get { } //Length: 7
	}

	public IList<MessageDescriptor> MessageTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string Name
	{
		 get { } //Length: 113
	}

	public string Package
	{
		 get { } //Length: 113
	}

	internal FileDescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public IList<FileDescriptor> PublicDependencies
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IList<ServiceDescriptor> Services
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Syntax Syntax
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	private static FileDescriptor() { }

	private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	internal string ComputeFullName(MessageDescriptor parent, string name) { }

	private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap() { }

	private void CrossLink() { }

	private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies) { }

	private IDescriptor FindDescriptorForPath(IList<Int32> path) { }

	public static void ForceReflectionInitialization() { }

	public static FileDescriptor FromGeneratedCode(Byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	[CompilerGenerated]
	public IList<FileDescriptor> get_Dependencies() { }

	[CompilerGenerated]
	internal DescriptorPool get_DescriptorPool() { }

	[CompilerGenerated]
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	public ExtensionCollection get_Extensions() { }

	[CompilerGenerated]
	public IList<MessageDescriptor> get_MessageTypes() { }

	public override string get_Name() { }

	public string get_Package() { }

	[CompilerGenerated]
	internal FileDescriptorProto get_Proto() { }

	[CompilerGenerated]
	public IList<FileDescriptor> get_PublicDependencies() { }

	[CompilerGenerated]
	public IList<ServiceDescriptor> get_Services() { }

	[CompilerGenerated]
	public Syntax get_Syntax() { }

	private static IEnumerable<Extension> GetAllDependedExtensions(FileDescriptor descriptor) { }

	private static IEnumerable<Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor) { }

	private static IEnumerable<Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo) { }

	private static IEnumerable<Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated) { }

	private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index) { }

	private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	private override FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File() { }

	private override string Google.Protobuf.Reflection.IDescriptor.get_FullName() { }

	public virtual string ToString() { }

}


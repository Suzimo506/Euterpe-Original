namespace Google.Protobuf.Reflection;

internal sealed class DescriptorPool
{
	private static readonly Regex ValidationRegex; //Field offset: 0x0
	private readonly IDictionary<String, IDescriptor> descriptorsByName; //Field offset: 0x10
	private readonly IDictionary<ObjectIntPair`1<IDescriptor>, FieldDescriptor> fieldsByNumber; //Field offset: 0x18
	private readonly IDictionary<ObjectIntPair`1<IDescriptor>, EnumValueDescriptor> enumValuesByNumber; //Field offset: 0x20
	private readonly HashSet<FileDescriptor> dependencies; //Field offset: 0x28

	private static DescriptorPool() { }

	internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles) { }

	internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) { }

	internal void AddFieldByNumber(FieldDescriptor field) { }

	internal void AddPackage(string fullName, FileDescriptor file) { }

	internal void AddSymbol(IDescriptor descriptor) { }

	internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) { }

	internal T FindSymbol(string fullName) { }

	private void ImportPublicDependencies(FileDescriptor file) { }

	internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) { }

	private static void ValidateSymbolName(IDescriptor descriptor) { }

}


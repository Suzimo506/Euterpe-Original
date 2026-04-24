namespace Google.Protobuf.Reflection;

public sealed class TypeRegistry
{
	[CompilerGenerated]
	private static readonly TypeRegistry <Empty>k__BackingField; //Field offset: 0x0
	private readonly Dictionary<String, MessageDescriptor> fullNameToMessageMap; //Field offset: 0x10

	public static TypeRegistry Empty
	{
		[CompilerGenerated]
		 get { } //Length: 86
	}

	private static TypeRegistry() { }

	private TypeRegistry(Dictionary<String, MessageDescriptor> fullNameToMessageMap) { }

	public MessageDescriptor Find(string fullName) { }

	[CompilerGenerated]
	public static TypeRegistry get_Empty() { }

}


namespace Google.Protobuf.Reflection;

public sealed class DescriptorDeclaration
{
	[CompilerGenerated]
	private readonly IDescriptor <Descriptor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <StartLine>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <StartColumn>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly int <EndLine>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <EndColumn>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly string <LeadingComments>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <TrailingComments>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly IReadOnlyList<String> <LeadingDetachedComments>k__BackingField; //Field offset: 0x38

	public int StartLine
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	private DescriptorDeclaration(IDescriptor descriptor, Location location) { }

	internal static DescriptorDeclaration FromProto(IDescriptor descriptor, Location location) { }

	[CompilerGenerated]
	public int get_StartLine() { }

}


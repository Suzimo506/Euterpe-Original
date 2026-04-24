namespace Google.Protobuf.Reflection;

public abstract class DescriptorBase : IDescriptor
{
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <FullName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly FileDescriptor <File>k__BackingField; //Field offset: 0x20

	public override FileDescriptor File
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string FullName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	internal DescriptorBase(FileDescriptor file, string fullName, int index) { }

	[CompilerGenerated]
	public override FileDescriptor get_File() { }

	[CompilerGenerated]
	public override string get_FullName() { }

	public abstract string get_Name() { }

	internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}


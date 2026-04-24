namespace Google.Protobuf.Reflection;

internal sealed class PackageDescriptor : IDescriptor
{
	private readonly string name; //Field offset: 0x10
	private readonly string fullName; //Field offset: 0x18
	private readonly FileDescriptor file; //Field offset: 0x20

	public override FileDescriptor File
	{
		 get { } //Length: 5
	}

	public override string FullName
	{
		 get { } //Length: 5
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	internal PackageDescriptor(string name, string fullName, FileDescriptor file) { }

	public override FileDescriptor get_File() { }

	public override string get_FullName() { }

	public override string get_Name() { }

}


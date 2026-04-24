namespace Google.Protobuf.Reflection;

public interface IDescriptor
{

	public FileDescriptor File
	{
		 get { } //Length: 0
	}

	public string FullName
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public FileDescriptor get_File() { }

	public string get_FullName() { }

	public string get_Name() { }

}


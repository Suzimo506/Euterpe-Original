namespace Google.Protobuf.Reflection;

public sealed class EnumValueDescriptor : DescriptorBase
{
	private readonly EnumDescriptor enumDescriptor; //Field offset: 0x28
	private readonly EnumValueDescriptorProto proto; //Field offset: 0x30

	public EnumDescriptor EnumDescriptor
	{
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 29
	}

	public int Number
	{
		 get { } //Length: 29
	}

	internal EnumValueDescriptorProto Proto
	{
		internal get { } //Length: 5
	}

	internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) { }

	public EnumDescriptor get_EnumDescriptor() { }

	public virtual string get_Name() { }

	public int get_Number() { }

	internal EnumValueDescriptorProto get_Proto() { }

}


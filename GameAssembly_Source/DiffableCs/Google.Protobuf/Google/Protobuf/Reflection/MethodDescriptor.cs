namespace Google.Protobuf.Reflection;

public sealed class MethodDescriptor : DescriptorBase
{
	private readonly MethodDescriptorProto proto; //Field offset: 0x28
	private readonly ServiceDescriptor service; //Field offset: 0x30
	private MessageDescriptor inputType; //Field offset: 0x38
	private MessageDescriptor outputType; //Field offset: 0x40

	public virtual string Name
	{
		 get { } //Length: 113
	}

	internal MethodDescriptorProto Proto
	{
		internal get { } //Length: 5
	}

	internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) { }

	internal void CrossLink() { }

	public virtual string get_Name() { }

	internal MethodDescriptorProto get_Proto() { }

}


namespace Google.Protobuf.Reflection;

public sealed class ServiceDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FileDescriptor file; //Field offset: 0x10
		public ServiceDescriptor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal MethodDescriptor <.ctor>b__0(MethodDescriptorProto method, int i) { }

	}

	private readonly ServiceDescriptorProto proto; //Field offset: 0x28
	private readonly IList<MethodDescriptor> methods; //Field offset: 0x30

	public virtual string Name
	{
		 get { } //Length: 113
	}

	internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) { }

	internal void CrossLink() { }

	public virtual string get_Name() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}


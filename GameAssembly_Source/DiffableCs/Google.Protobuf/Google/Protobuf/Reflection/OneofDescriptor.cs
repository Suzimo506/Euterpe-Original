namespace Google.Protobuf.Reflection;

public sealed class OneofDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <.ctor>b__0(FieldDescriptorProto fieldProto) { }

	}

	private readonly OneofDescriptorProto proto; //Field offset: 0x28
	private MessageDescriptor containingType; //Field offset: 0x30
	private IList<FieldDescriptor> fields; //Field offset: 0x38
	private readonly OneofAccessor accessor; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <IsSynthetic>k__BackingField; //Field offset: 0x48

	public OneofAccessor Accessor
	{
		 get { } //Length: 5
	}

	public MessageDescriptor ContainingType
	{
		 get { } //Length: 5
	}

	public IList<FieldDescriptor> Fields
	{
		 get { } //Length: 5
	}

	public bool IsSynthetic
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 113
	}

	internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) { }

	private OneofAccessor CreateAccessor(string clrName) { }

	internal void CrossLink() { }

	public OneofAccessor get_Accessor() { }

	public MessageDescriptor get_ContainingType() { }

	public IList<FieldDescriptor> get_Fields() { }

	[CompilerGenerated]
	public bool get_IsSynthetic() { }

	public virtual string get_Name() { }

}


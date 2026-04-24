namespace Google.Protobuf.Reflection;

public sealed class EnumDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public FileDescriptor file; //Field offset: 0x10
		public EnumDescriptor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal EnumValueDescriptor <.ctor>b__0(EnumValueDescriptorProto value, int i) { }

	}

	private readonly EnumDescriptorProto proto; //Field offset: 0x28
	private readonly MessageDescriptor containingType; //Field offset: 0x30
	private readonly IList<EnumValueDescriptor> values; //Field offset: 0x38
	private readonly Type clrType; //Field offset: 0x40

	public virtual string Name
	{
		 get { } //Length: 113
	}

	public IList<EnumValueDescriptor> Values
	{
		 get { } //Length: 5
	}

	internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType) { }

	public virtual string get_Name() { }

	public IList<EnumValueDescriptor> get_Values() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}


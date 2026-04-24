namespace Google.Protobuf.Reflection;

public sealed class OneofAccessor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public OneofDescriptor descriptor; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal int <ForSyntheticOneof>b__0(IMessage message) { }

		internal void <ForSyntheticOneof>b__1(IMessage message) { }

	}

	private readonly Func<IMessage, Int32> caseDelegate; //Field offset: 0x10
	private readonly Action<IMessage> clearDelegate; //Field offset: 0x18
	[CompilerGenerated]
	private readonly OneofDescriptor <Descriptor>k__BackingField; //Field offset: 0x20

	public OneofDescriptor Descriptor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private OneofAccessor(OneofDescriptor descriptor, Func<IMessage, Int32> caseDelegate, Action<IMessage> clearDelegate) { }

	public void Clear(IMessage message) { }

	internal static OneofAccessor ForRegularOneof(OneofDescriptor descriptor, PropertyInfo caseProperty, MethodInfo clearMethod) { }

	internal static OneofAccessor ForSyntheticOneof(OneofDescriptor descriptor) { }

	[CompilerGenerated]
	public OneofDescriptor get_Descriptor() { }

	public FieldDescriptor GetCaseFieldDescriptor(IMessage message) { }

}


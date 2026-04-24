namespace Google.Protobuf.Reflection;

internal sealed class ExtensionAccessor : IFieldAccessor
{
	private readonly Extension extension; //Field offset: 0x10
	private readonly IExtensionReflectionHelper helper; //Field offset: 0x18
	[CompilerGenerated]
	private readonly FieldDescriptor <Descriptor>k__BackingField; //Field offset: 0x20

	public override FieldDescriptor Descriptor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ExtensionAccessor(FieldDescriptor descriptor) { }

	public override void Clear(IMessage message) { }

	[CompilerGenerated]
	public override FieldDescriptor get_Descriptor() { }

	public override object GetValue(IMessage message) { }

	public override bool HasValue(IMessage message) { }

}


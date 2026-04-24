namespace Google.Protobuf.Reflection;

internal abstract class FieldAccessorBase : IFieldAccessor
{
	private readonly Func<IMessage, Object> getValueDelegate; //Field offset: 0x10
	private readonly FieldDescriptor descriptor; //Field offset: 0x18

	public override FieldDescriptor Descriptor
	{
		 get { } //Length: 5
	}

	internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor) { }

	public abstract void Clear(IMessage message) { }

	public override FieldDescriptor get_Descriptor() { }

	public override object GetValue(IMessage message) { }

	public abstract bool HasValue(IMessage message) { }

	public abstract void SetValue(IMessage message, object value) { }

}


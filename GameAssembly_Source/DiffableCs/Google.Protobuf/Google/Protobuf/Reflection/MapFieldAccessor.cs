namespace Google.Protobuf.Reflection;

internal sealed class MapFieldAccessor : FieldAccessorBase
{

	internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) { }

	public virtual void Clear(IMessage message) { }

	public virtual bool HasValue(IMessage message) { }

	public virtual void SetValue(IMessage message, object value) { }

}


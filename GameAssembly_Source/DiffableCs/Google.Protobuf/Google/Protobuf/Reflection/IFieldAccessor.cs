namespace Google.Protobuf.Reflection;

public interface IFieldAccessor
{

	public FieldDescriptor Descriptor
	{
		 get { } //Length: 0
	}

	public void Clear(IMessage message) { }

	public FieldDescriptor get_Descriptor() { }

	public object GetValue(IMessage message) { }

	public bool HasValue(IMessage message) { }

}


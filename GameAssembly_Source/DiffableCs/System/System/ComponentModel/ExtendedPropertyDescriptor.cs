namespace System.ComponentModel;

internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
{
	private readonly ReflectPropertyDescriptor extenderInfo; //Field offset: 0x88
	private readonly IExtenderProvider provider; //Field offset: 0x90

	public virtual Type ComponentType
	{
		 get { } //Length: 42
	}

	public virtual string DisplayName
	{
		 get { } //Length: 947
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 227
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 43
	}

	public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	public virtual Type get_ComponentType() { }

	public virtual string get_DisplayName() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	public virtual object GetValue(object comp) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object comp) { }

}


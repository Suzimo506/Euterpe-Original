namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute
{
	private PropertyDescriptor extenderProperty; //Field offset: 0x10
	private IExtenderProvider provider; //Field offset: 0x18
	private Type receiverType; //Field offset: 0x20

	public IExtenderProvider Provider
	{
		 get { } //Length: 5
	}

	public Type ReceiverType
	{
		 get { } //Length: 5
	}

	public ExtenderProvidedPropertyAttribute() { }

	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	public virtual bool Equals(object obj) { }

	public IExtenderProvider get_Provider() { }

	public Type get_ReceiverType() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}


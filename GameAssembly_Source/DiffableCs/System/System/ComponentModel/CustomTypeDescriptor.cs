namespace System.ComponentModel;

public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	private ICustomTypeDescriptor _parent; //Field offset: 0x10

	protected CustomTypeDescriptor() { }

	public override AttributeCollection GetAttributes() { }

	public override TypeConverter GetConverter() { }

	public override PropertyDescriptorCollection GetProperties() { }

	public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public override object GetPropertyOwner(PropertyDescriptor pd) { }

}


namespace System.ComponentModel;

public interface ICustomTypeDescriptor
{

	public AttributeCollection GetAttributes() { }

	public TypeConverter GetConverter() { }

	public PropertyDescriptorCollection GetProperties() { }

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public object GetPropertyOwner(PropertyDescriptor pd) { }

}


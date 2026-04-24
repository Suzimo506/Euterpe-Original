namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AttributeProviderAttribute : Attribute
{
	private string _typeName; //Field offset: 0x10
	private string _propertyName; //Field offset: 0x18

	public string PropertyName
	{
		 get { } //Length: 5
	}

	public string TypeName
	{
		 get { } //Length: 5
	}

	public string get_PropertyName() { }

	public string get_TypeName() { }

}


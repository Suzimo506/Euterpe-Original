namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TypeDescriptionProviderAttribute : Attribute
{
	private string _typeName; //Field offset: 0x10

	public string TypeName
	{
		 get { } //Length: 5
	}

	public TypeDescriptionProviderAttribute(string typeName) { }

	public TypeDescriptionProviderAttribute(Type type) { }

	public string get_TypeName() { }

}


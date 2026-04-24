namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ProvidePropertyAttribute : Attribute
{
	private readonly string propertyName; //Field offset: 0x10
	private readonly string receiverTypeName; //Field offset: 0x18

	public string PropertyName
	{
		 get { } //Length: 5
	}

	public string ReceiverTypeName
	{
		 get { } //Length: 5
	}

	public string get_PropertyName() { }

	public string get_ReceiverTypeName() { }

}


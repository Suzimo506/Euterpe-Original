namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomValueDrawerAttribute : Attribute
{
	public string Action; //Field offset: 0x10

	[Obsolete]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public CustomValueDrawerAttribute(string action) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}


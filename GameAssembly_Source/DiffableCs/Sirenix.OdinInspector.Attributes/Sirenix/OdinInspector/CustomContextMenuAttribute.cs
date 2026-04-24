namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class CustomContextMenuAttribute : Attribute
{
	public string MenuItem; //Field offset: 0x10
	public string Action; //Field offset: 0x18

	[Obsolete]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public CustomContextMenuAttribute(string menuItem, string action) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}


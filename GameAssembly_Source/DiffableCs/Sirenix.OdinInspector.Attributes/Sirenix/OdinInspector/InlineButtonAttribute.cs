namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class InlineButtonAttribute : Attribute
{
	public string Action; //Field offset: 0x10
	public string Label; //Field offset: 0x18
	public string ShowIf; //Field offset: 0x20

	[Obsolete]
	public string MemberMethod
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public InlineButtonAttribute(string action, string label = null) { }

	public string get_MemberMethod() { }

	public void set_MemberMethod(string value) { }

}


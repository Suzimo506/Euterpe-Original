namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class EnableIfAttribute : Attribute
{
	public string Condition; //Field offset: 0x10
	public object Value; //Field offset: 0x18

	[Obsolete]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public EnableIfAttribute(string condition) { }

	public EnableIfAttribute(string condition, object optionalValue) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}


namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DontApplyToListElements]
public sealed class ShowIfAttribute : Attribute
{
	public string Condition; //Field offset: 0x10
	public object Value; //Field offset: 0x18
	public bool Animate; //Field offset: 0x20

	[Obsolete]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ShowIfAttribute(string condition, bool animate = true) { }

	public ShowIfAttribute(string condition, object optionalValue, bool animate = true) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}


namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TypeFilterAttribute : Attribute
{
	public string FilterGetter; //Field offset: 0x10
	public string DropdownTitle; //Field offset: 0x18
	public bool DrawValueNormally; //Field offset: 0x20

	[Obsolete]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public TypeFilterAttribute(string filterGetter) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}


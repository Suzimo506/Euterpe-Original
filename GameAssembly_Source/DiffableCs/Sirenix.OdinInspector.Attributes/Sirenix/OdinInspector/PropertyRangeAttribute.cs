namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class PropertyRangeAttribute : Attribute
{
	public double Min; //Field offset: 0x10
	public double Max; //Field offset: 0x18
	public string MinGetter; //Field offset: 0x20
	public string MaxGetter; //Field offset: 0x28

	[Obsolete]
	public string MaxMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	[Obsolete]
	public string MinMember
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public PropertyRangeAttribute(double min, double max) { }

	public PropertyRangeAttribute(string minGetter, double max) { }

	public PropertyRangeAttribute(double min, string maxGetter) { }

	public PropertyRangeAttribute(string minGetter, string maxGetter) { }

	public string get_MaxMember() { }

	public string get_MinMember() { }

	public void set_MaxMember(string value) { }

	public void set_MinMember(string value) { }

}


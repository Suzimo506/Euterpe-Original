namespace PeroTools2.Commons;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConstGroupAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <groupName>k__BackingField; //Field offset: 0x10

	public string groupName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ConstGroupAttribute(string name) { }

	[CompilerGenerated]
	public string get_groupName() { }

}


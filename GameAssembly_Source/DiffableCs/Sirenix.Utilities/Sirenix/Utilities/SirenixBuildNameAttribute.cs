namespace Sirenix.Utilities;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SirenixBuildNameAttribute : Attribute
{
	[CompilerGenerated]
	private string <BuildName>k__BackingField; //Field offset: 0x10

	public private string BuildName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public SirenixBuildNameAttribute(string buildName) { }

	[CompilerGenerated]
	public string get_BuildName() { }

	[CompilerGenerated]
	private void set_BuildName(string value) { }

}


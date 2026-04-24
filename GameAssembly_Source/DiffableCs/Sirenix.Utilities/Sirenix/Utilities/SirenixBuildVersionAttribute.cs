namespace Sirenix.Utilities;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SirenixBuildVersionAttribute : Attribute
{
	[CompilerGenerated]
	private string <Version>k__BackingField; //Field offset: 0x10

	public private string Version
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public SirenixBuildVersionAttribute(string version) { }

	[CompilerGenerated]
	public string get_Version() { }

	[CompilerGenerated]
	private void set_Version(string value) { }

}


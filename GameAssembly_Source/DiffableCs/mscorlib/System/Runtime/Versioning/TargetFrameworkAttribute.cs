namespace System.Runtime.Versioning;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TargetFrameworkAttribute : Attribute
{
	private string _frameworkName; //Field offset: 0x10
	private string _frameworkDisplayName; //Field offset: 0x18

	public string FrameworkDisplayName
	{
		 set { } //Length: 12
	}

	public TargetFrameworkAttribute(string frameworkName) { }

	public void set_FrameworkDisplayName(string value) { }

}


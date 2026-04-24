namespace Google.Protobuf.Reflection;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OriginalNameAttribute : Attribute
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <PreferredAlias>k__BackingField; //Field offset: 0x18

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool PreferredAlias
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public OriginalNameAttribute(string name) { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public bool get_PreferredAlias() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_PreferredAlias(bool value) { }

}


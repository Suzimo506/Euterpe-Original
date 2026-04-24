namespace PeroTools2.GeneralLocalization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SourcePathAttribute : Attribute
{
	[CompilerGenerated]
	private string <path>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <order>k__BackingField; //Field offset: 0x18

	public private int order
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string path
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public SourcePathAttribute(string path, int order = 0) { }

	[CompilerGenerated]
	public int get_order() { }

	[CompilerGenerated]
	public string get_path() { }

	[CompilerGenerated]
	private void set_order(int value) { }

	[CompilerGenerated]
	private void set_path(string value) { }

}


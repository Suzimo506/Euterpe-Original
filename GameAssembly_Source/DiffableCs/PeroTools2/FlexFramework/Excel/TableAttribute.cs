namespace FlexFramework.Excel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TableAttribute : Attribute
{
	[CompilerGenerated]
	private Int32[] <Ignore>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <SafeMode>k__BackingField; //Field offset: 0x18

	public private Int32[] Ignore
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public bool SafeMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TableAttribute(Int32[] ignore) { }

	[CompilerGenerated]
	public Int32[] get_Ignore() { }

	[CompilerGenerated]
	public bool get_SafeMode() { }

	[CompilerGenerated]
	private void set_Ignore(Int32[] value) { }

	[CompilerGenerated]
	public void set_SafeMode(bool value) { }

}


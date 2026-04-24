namespace FlexFramework.Excel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ColumnAttribute : Attribute
{
	[CompilerGenerated]
	private int <Column>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <Default>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Fallback>k__BackingField; //Field offset: 0x20

	public private int Column
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private object Default
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private bool Fallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ColumnAttribute(int column) { }

	public ColumnAttribute(int column, object default) { }

	public ColumnAttribute(string column) { }

	public ColumnAttribute(string column, object default) { }

	[CompilerGenerated]
	public int get_Column() { }

	[CompilerGenerated]
	public object get_Default() { }

	[CompilerGenerated]
	public bool get_Fallback() { }

	[CompilerGenerated]
	private void set_Column(int value) { }

	[CompilerGenerated]
	private void set_Default(object value) { }

	[CompilerGenerated]
	private void set_Fallback(bool value) { }

}


namespace FlexFramework.Excel;

public sealed class WorkSheet : Table
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Cell, Boolean> <>9__14_0; //Field offset: 0x8
		public static Func<Row, Row> <>9__15_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Row <DeepClone>b__15_0(Row row) { }

		internal bool <Merge>b__14_0(Cell c) { }

	}

	[CompilerGenerated]
	private string <ID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ReadOnlyCollection<Range> <Spans>k__BackingField; //Field offset: 0x30

	public private string ID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private ReadOnlyCollection<Range> Spans
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public WorkSheet(string id, string name, IList<Row> rows) { }

	public WorkSheet(string id, string name, IList<Row> rows, IList<Range> spans) { }

	public virtual Table DeepClone() { }

	[CompilerGenerated]
	public string get_ID() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public ReadOnlyCollection<Range> get_Spans() { }

	public void Merge() { }

	[CompilerGenerated]
	private void set_ID(string value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	[CompilerGenerated]
	private void set_Spans(ReadOnlyCollection<Range> value) { }

	public virtual Table ShallowClone() { }

}


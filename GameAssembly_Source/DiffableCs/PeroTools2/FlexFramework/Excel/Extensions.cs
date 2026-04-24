namespace FlexFramework.Excel;

[Extension]
public static class Extensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String, String> <>9__20_1; //Field offset: 0x8
		public static Func<Row, IEnumerable`1<Cell>> <>9__24_0; //Field offset: 0x10
		public static Func<Row, Int32> <>9__29_0; //Field offset: 0x18
		public static Func<Cell, Boolean> <>9__32_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <Dump>b__20_1(string a, string b) { }

		internal int <Expand>b__29_0(Row row) { }

		internal bool <IsEmpty>b__32_0(Cell col) { }

		internal IEnumerable<Cell> <Select>b__24_0(Row row) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public char delimiter; //Field offset: 0x10
		public char enclose; //Field offset: 0x12

		public <>c__DisplayClass16_0() { }

		internal string <Dump>b__0(Cell c) { }

		internal string <Dump>b__1(string a, string b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public char delimiter; //Field offset: 0x10
		public char enclose; //Field offset: 0x12

		public <>c__DisplayClass20_0() { }

		internal string <Dump>b__0(Row r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Address ad; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <Select>b__0(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Address ad; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <Select>b__1(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public String[] args; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <Select>b__0(WorkSheet s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public String[] args; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <SelectRange>b__0(WorkSheet s) { }

	}


	[Extension]
	public static Table Collapse(Table table) { }

	[Extension]
	public static object Convert(Cell cell, Type type) { }

	[Extension]
	public static IEnumerable<Object> Convert(Table table, Type type, int row) { }

	[Extension]
	public static IEnumerable<Object> Convert(Table table, ITableGenerator generator) { }

	[Extension]
	public static IEnumerable<Object> Convert(Table table, Type type, string expression, Int32[] exclude) { }

	[Extension]
	public static IEnumerable<T> Convert(Table table, string expression, Int32[] exclude) { }

	[Extension]
	public static IEnumerable<T> Convert(Table table, int row) { }

	[Extension]
	public static IEnumerable<T> Convert(Table table, ITableGenerator<T> generator) { }

	[Extension]
	public static IEnumerable<Object> Convert(Table table, Type type) { }

	[Extension]
	public static object Convert(Row row, IGenerator generator) { }

	[Extension]
	public static object Convert(Row row, Type type, IEnumerable<Cell> cols) { }

	[Extension]
	public static object Convert(Row row, Type type, string expression) { }

	[Extension]
	public static T Convert(Row row, IEnumerable<Cell> cols) { }

	[Extension]
	public static T Convert(Row row, string expression) { }

	[Extension]
	public static T Convert(Row row, IGenerator<T> generator) { }

	[Extension]
	public static T Convert(Cell cell) { }

	[Extension]
	public static IEnumerable<T> Convert(Table table) { }

	[Extension]
	public static string Dump(Table table) { }

	[Extension]
	public static string Dump(Table table, char delimiter, char enclose) { }

	[Extension]
	public static string Dump(Row row, char delimiter, char enclose) { }

	[Extension]
	public static string Dump(Cell cell, char delimiter, char enclose) { }

	[Extension]
	public static string Dump(Row row) { }

	[Extension]
	public static string Dump(Cell cell) { }

	[Extension]
	public static Table Expand(Table table) { }

	[Extension]
	public static bool IsEmpty(Row row) { }

	[Extension]
	public static void Recalculate(Table table) { }

	[Extension]
	public static Table Rotate(Table table) { }

	[Extension]
	public static Cell Select(Row row, string address) { }

	[Extension]
	public static Cell Select(Table table, string address) { }

	[Extension]
	public static Cell Select(WorkBook book, string path) { }

	[Extension]
	public static IEnumerable<Cell> SelectRange(Row row, string range) { }

	[Extension]
	public static IEnumerable<Cell> SelectRange(Table table, string range) { }

	[Extension]
	public static IEnumerable<Cell> SelectRange(WorkBook book, string path) { }

}


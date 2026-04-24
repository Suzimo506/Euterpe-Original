namespace FlexFramework.Excel;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class Table : ReadOnlyCollection<Row>, ICloneable<Table>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Row, IEnumerable`1<Cell>> <>9__6_0; //Field offset: 0x8
		public static Func<Row, IEnumerable`1<Cell>> <>9__8_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Cell> <get_Item>b__6_0(Row row) { }

		internal IEnumerable<Cell> <get_Item>b__8_0(Row row) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Address address; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <get_Item>b__1(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Range range; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <get_Item>b__1(Cell cell) { }

	}


	public Cell Item
	{
		 get { } //Length: 213
	}

	public Cell Item
	{
		 get { } //Length: 356
	}

	public IEnumerable<Cell> Item
	{
		 get { } //Length: 359
	}

	public IList<Row> Rows
	{
		 get { } //Length: 56
	}

	public Table(IList<Row> list) { }

	public abstract Table DeepClone() { }

	public Cell get_Item(string address) { }

	public Cell get_Item(Address address) { }

	public IEnumerable<Cell> get_Item(Range range) { }

	public IList<Row> get_Rows() { }

	public abstract Table ShallowClone() { }

}


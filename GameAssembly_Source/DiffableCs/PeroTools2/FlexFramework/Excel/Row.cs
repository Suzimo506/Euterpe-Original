namespace FlexFramework.Excel;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Row : ReadOnlyCollection<Cell>, ICloneable<Row>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Cell, Cell> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Cell <DeepClone>b__10_0(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Address address; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <get_Item>b__0(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Range range; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <get_Item>b__0(Cell cell) { }

	}


	public IList<Cell> Cells
	{
		 get { } //Length: 56
	}

	public Cell Item
	{
		 get { } //Length: 341
	}

	public Cell Item
	{
		 get { } //Length: 160
	}

	public IEnumerable<Cell> Item
	{
		 get { } //Length: 163
	}

	public Row(IList<Cell> list) { }

	public Row() { }

	public override Row DeepClone() { }

	public IList<Cell> get_Cells() { }

	public Cell get_Item(string address) { }

	public Cell get_Item(Address address) { }

	public IEnumerable<Cell> get_Item(Range range) { }

	public override Row ShallowClone() { }

}


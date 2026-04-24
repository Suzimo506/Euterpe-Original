namespace FlexFramework.Excel;

public sealed class TableMapper : TableMapperBase<TableMapper`1<T>>, IGenerator<T>, ITableGenerator<T>
{

	public TableMapper`1() { }

	[CompilerGenerated]
	private bool <FlexFramework.Excel.ITableGenerator<T>.Instantiate>b__3_0(Row r, int i) { }

	[CompilerGenerated]
	private T <FlexFramework.Excel.ITableGenerator<T>.Instantiate>b__3_1(Row row) { }

	protected virtual object CreateInstance() { }

	private override T FlexFramework.Excel.IGenerator<T>.Instantiate(Row row) { }

	private override IEnumerable<T> FlexFramework.Excel.ITableGenerator<T>.Instantiate(Table table) { }

}


namespace PeroTools2.Datas.Excel;

public sealed class SheetData
{
	[SerializeField]
	private List<Dictionary`2<String, IValue>> m_Sheet; //Field offset: 0x10
	private List<IValue> m_CachedList; //Field offset: 0x18

	public IEnumerable<String> columnNames
	{
		 get { } //Length: 104
	}

	public SheetData(List<Dictionary`2<String, IValue>> sheet) { }

	public IEnumerable<String> get_columnNames() { }

	public IEnumerable<IValue> GetValuesOfColumn(string columnName) { }

	public T Value(int index, string columnName) { }

	public TValue Value(string cmpColumn, TCmpValue cmpValue, string column) { }

}


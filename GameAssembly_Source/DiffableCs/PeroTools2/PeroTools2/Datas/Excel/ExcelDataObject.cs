namespace PeroTools2.Datas.Excel;

public class ExcelDataObject : DataObject
{
	[SerializeField]
	internal string path; //Field offset: 0x68

	public ExcelDataObject() { }

	[Obsolete]
	public T Value(string sheetName, int index, string key) { }

}


namespace FlexFramework.Excel;

public interface ITableGenerator
{

	public IEnumerable<T> Instantiate(Table table) { }

}


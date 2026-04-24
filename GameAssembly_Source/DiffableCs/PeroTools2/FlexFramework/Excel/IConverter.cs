namespace FlexFramework.Excel;

public interface IConverter
{

	public Type Type
	{
		 get { } //Length: 0
	}

	public object Convert(string input) { }

	public Type get_Type() { }

}


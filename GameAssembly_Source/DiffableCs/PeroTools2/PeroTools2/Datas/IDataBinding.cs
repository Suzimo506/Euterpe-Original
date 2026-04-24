namespace PeroTools2.Datas;

[Obsolete]
public interface IDataBinding : IBinding
{

	public Dictionary<String, ValueDelegate> datas
	{
		 get { } //Length: 0
	}

	public Dictionary<String, ValueDelegate> get_datas() { }

}


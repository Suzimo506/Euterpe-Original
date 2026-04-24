namespace PeroTools2.Datas;

public interface IGenericDataBinding : IBinding
{

	public List<DataBinder> datas
	{
		 get { } //Length: 0
	}

	public List<DataBinder> get_datas() { }

}


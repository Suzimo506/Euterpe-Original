namespace PeroTools2.Datas;

public sealed class DataBinder : DataBinder
{
	private readonly Action<TResult> m_Action; //Field offset: 0x0

	internal DataBinder`2(string name, Action<TResult> action) { }

	protected virtual void BindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	protected virtual void UnbindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

}


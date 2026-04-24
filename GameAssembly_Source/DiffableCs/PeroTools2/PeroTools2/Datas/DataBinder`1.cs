namespace PeroTools2.Datas;

public sealed class DataBinder : DataBinder
{
	private readonly Action<TIValue> m_Action; //Field offset: 0x0

	internal DataBinder`1(string name, Action<TIValue> action) { }

	protected virtual void BindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	private void OnVariableChanged(IVariable var) { }

	protected virtual void UnbindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

}


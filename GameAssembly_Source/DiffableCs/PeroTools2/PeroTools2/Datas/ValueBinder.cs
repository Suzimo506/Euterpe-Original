namespace PeroTools2.Datas;

public sealed class ValueBinder : DataBinder
{
	private readonly ValueDelegate m_Action; //Field offset: 0x18

	internal ValueBinder(string name, ValueDelegate action) { }

	protected virtual void BindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	private void OnVariableChanged(IVariable var) { }

	protected virtual void UnbindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

}


namespace PeroTools2.Datas;

public abstract class DataBinder
{
	protected readonly string name; //Field offset: 0x10

	protected DataBinder(string name) { }

	internal void Bind(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	protected abstract void BindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	public static ValueBinder Create(string name, ValueDelegate action) { }

	public static DataBinder<TIValue> Create(string name, Action<TIValue> action) { }

	public static DataBinder<TIValue, TResult> Create(string name, Action<TResult> action) { }

	internal void Unbind(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

	protected abstract void UnbindImpl(DataManager manager, Dictionary<String, Action`1<IVariable>> variableActions) { }

}


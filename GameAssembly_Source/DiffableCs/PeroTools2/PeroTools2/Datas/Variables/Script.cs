namespace PeroTools2.Datas.Variables;

public class Script : IVariable
{
	[SerializeField]
	private GameObject m_GameObject; //Field offset: 0x10
	[SerializeField]
	private List<Reflecter> m_Reflecters; //Field offset: 0x18
	private IValue m_Value; //Field offset: 0x20

	public override event Action<IVariable> onVariableChanged
	{
		 add { } //Length: 321
		 remove { } //Length: 321
	}

	public Script() { }

	public override void add_onVariableChanged(Action<IVariable> value) { }

	public object GetResult() { }

	public override T GetValue() { }

	public override void remove_onVariableChanged(Action<IVariable> value) { }

	public void SetResult(object _result) { }

}


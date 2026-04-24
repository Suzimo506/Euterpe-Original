namespace PeroTools2.Datas.Variables;

public class Ref : IVariable
{
	internal enum VariableType
	{
		Global = 0,
		Local = 1,
		Internal = 2,
	}

	[SerializeField]
	private VariableType m_Type; //Field offset: 0x10
	[SerializeField]
	private string m_Uid; //Field offset: 0x18
	[SerializeField]
	private IVariable m_Variable; //Field offset: 0x20
	[SerializeField]
	private object m_OnCustomEvent; //Field offset: 0x28
	[SerializeField]
	private Type m_CustomEventType; //Field offset: 0x30
	private IValue m_Value; //Field offset: 0x38

	public override event Action<IVariable> onVariableChanged
	{
		 add { } //Length: 136
		 remove { } //Length: 136
	}

	public Ref() { }

	public override void add_onVariableChanged(Action<IVariable> value) { }

	public object GetResult() { }

	public override T GetValue() { }

	public override void remove_onVariableChanged(Action<IVariable> value) { }

	public void SetResult(object _result) { }

}


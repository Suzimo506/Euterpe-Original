namespace PeroTools2.Datas.Variables;

public class Constance : IVariable
{
	[SerializeField]
	private IValue m_Value; //Field offset: 0x10
	[CompilerGenerated]
	private Action<IVariable> onVariableChanged; //Field offset: 0x18
	private bool m_InitDelegate; //Field offset: 0x20

	public override event Action<IVariable> onVariableChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Constance(IValue value) { }

	public Constance() { }

	[CompilerGenerated]
	private void <GetValue>b__5_0(IValue result) { }

	[CompilerGenerated]
	public override void add_onVariableChanged(Action<IVariable> value) { }

	public override T GetValue() { }

	[CompilerGenerated]
	public override void remove_onVariableChanged(Action<IVariable> value) { }

	public void SetResult(object result) { }

}


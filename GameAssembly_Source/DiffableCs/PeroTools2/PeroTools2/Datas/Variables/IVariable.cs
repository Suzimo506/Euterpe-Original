namespace PeroTools2.Datas.Variables;

public interface IVariable
{

	public event Action<IVariable> onVariableChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_onVariableChanged(Action<IVariable> value) { }

	public T GetValue() { }

	[CompilerGenerated]
	public void remove_onVariableChanged(Action<IVariable> value) { }

}


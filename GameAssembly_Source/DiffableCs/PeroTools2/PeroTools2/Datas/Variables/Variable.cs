namespace PeroTools2.Datas.Variables;

public class Variable : SerializedMonoBehaviour, IVariable
{
	public IVariable variable; //Field offset: 0x58
	private IValue m_Value; //Field offset: 0x60
	[CompilerGenerated]
	private string <comment>k__BackingField; //Field offset: 0x68

	public override event Action<IVariable> onVariableChanged
	{
		 add { } //Length: 87
		 remove { } //Length: 87
	}

	[SerializeField]
	public private string comment
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Variable() { }

	public override void add_onVariableChanged(Action<IVariable> value) { }

	[CompilerGenerated]
	public string get_comment() { }

	public override T GetValue() { }

	public override void remove_onVariableChanged(Action<IVariable> value) { }

	[CompilerGenerated]
	private void set_comment(string value) { }

}


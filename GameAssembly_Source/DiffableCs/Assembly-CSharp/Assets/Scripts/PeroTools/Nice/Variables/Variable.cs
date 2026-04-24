namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Variable : IVariable, IValue
{
	[SerializeField]
	private VariableType m_Type; //Field offset: 0x10
	[SerializeField]
	private string m_Uid; //Field offset: 0x18
	[SerializeField]
	private IVariable m_Variable; //Field offset: 0x20

	public override object result
	{
		 get { } //Length: 139
		 set { } //Length: 135
	}

	public Variable() { }

	public override object get_result() { }

	public override void set_result(object value) { }

}


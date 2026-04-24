namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Constance : IVariable, IValue
{
	[SerializeField]
	private IValue m_Value; //Field offset: 0x10

	public override object result
	{
		 get { } //Length: 72
		 set { } //Length: 118
	}

	public Constance(IValue value) { }

	public Constance() { }

	public override object get_result() { }

	public override void set_result(object value) { }

}


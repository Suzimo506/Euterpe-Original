namespace Assets.Scripts.PeroTools.Nice.Variables;

public class Script : IVariable, IValue
{
	[SerializeField]
	private GameObject m_GameObject; //Field offset: 0x10
	[SerializeField]
	private List<Reflecter> m_Reflecters; //Field offset: 0x18

	public override object result
	{
		 get { } //Length: 7
		 set { } //Length: 3
	}

	public Script() { }

	public override object get_result() { }

	public object GetValue() { }

	public void Invoke() { }

	public override void set_result(object value) { }

	public void SetValue(object value) { }

}


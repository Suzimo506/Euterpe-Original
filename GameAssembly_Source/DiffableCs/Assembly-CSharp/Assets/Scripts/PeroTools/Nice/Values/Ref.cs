namespace Assets.Scripts.PeroTools.Nice.Values;

public class Ref : IValue
{
	[SerializeField]
	private object m_Result; //Field offset: 0x10

	public override object result
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Ref() { }

	public override object get_result() { }

	public override void set_result(object value) { }

}


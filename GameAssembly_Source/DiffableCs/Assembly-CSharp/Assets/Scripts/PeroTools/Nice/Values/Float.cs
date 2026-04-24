namespace Assets.Scripts.PeroTools.Nice.Values;

public class Float : IValue
{
	[SerializeField]
	private float m_Result; //Field offset: 0x10

	public override object result
	{
		 get { } //Length: 70
		 set { } //Length: 106
	}

	public Float() { }

	public override object get_result() { }

	public override void set_result(object value) { }

}


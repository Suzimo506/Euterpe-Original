namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Wait : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Duration; //Field offset: 0x10

	public virtual float duration
	{
		 get { } //Length: 57
	}

	public Wait() { }

	public virtual float get_duration() { }

}


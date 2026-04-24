namespace Assets.Scripts.PeroTools.Nice.Actions;

public class Deactivate : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10

	public Deactivate() { }

	public virtual void Execute() { }

}


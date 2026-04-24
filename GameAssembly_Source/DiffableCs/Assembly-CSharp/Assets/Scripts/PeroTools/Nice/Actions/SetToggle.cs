namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetToggle : Action
{
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_IsOn; //Field offset: 0x18

	public SetToggle() { }

	public virtual void Execute() { }

}


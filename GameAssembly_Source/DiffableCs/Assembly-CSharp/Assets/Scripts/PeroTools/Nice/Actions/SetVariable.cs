namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetVariable : Action
{
	[SerializeField]
	private IVariable m_Variable; //Field offset: 0x10
	[SerializeField]
	private IVariable m_TargetVariable; //Field offset: 0x18

	public SetVariable() { }

	public virtual void Execute() { }

	private bool IsVariableType() { }

}


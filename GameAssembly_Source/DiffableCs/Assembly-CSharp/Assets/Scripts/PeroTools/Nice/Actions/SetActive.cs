namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetActive : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_IsActive; //Field offset: 0x18

	public SetActive() { }

	public virtual void Execute() { }

}


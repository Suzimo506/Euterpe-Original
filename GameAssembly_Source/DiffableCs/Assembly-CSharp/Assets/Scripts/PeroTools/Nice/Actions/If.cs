namespace Assets.Scripts.PeroTools.Nice.Actions;

public class If : Group
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_IsExecute; //Field offset: 0x28

	public If() { }

	public virtual void Execute() { }

}


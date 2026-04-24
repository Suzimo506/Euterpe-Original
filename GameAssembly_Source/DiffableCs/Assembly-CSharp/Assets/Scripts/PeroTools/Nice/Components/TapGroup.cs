namespace Assets.Scripts.PeroTools.Nice.Components;

public class TapGroup : Action
{
	public Transform tapGroupRoot; //Field offset: 0x10
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable activeIndex; //Field offset: 0x18
	private Transform m_CurrentActive; //Field offset: 0x20

	public TapGroup() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

}


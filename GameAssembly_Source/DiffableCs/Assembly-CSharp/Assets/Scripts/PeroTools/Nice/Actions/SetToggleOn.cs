namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetToggleOn : Action
{
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x10

	public SetToggleOn() { }

	public virtual void Execute() { }

}


namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetToggleOff : Action
{
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x10

	public SetToggleOff() { }

	public virtual void Execute() { }

}


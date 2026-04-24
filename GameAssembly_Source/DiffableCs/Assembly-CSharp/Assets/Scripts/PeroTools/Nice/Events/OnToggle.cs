namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnToggle : Event
{
	[SerializeField]
	private Toggle m_Toggle; //Field offset: 0x70
	private bool m_IsOn; //Field offset: 0x78

	public OnToggle() { }

	private void Listener(bool isOn) { }

	protected virtual void OnEnter() { }

	protected virtual void OnExit() { }

}


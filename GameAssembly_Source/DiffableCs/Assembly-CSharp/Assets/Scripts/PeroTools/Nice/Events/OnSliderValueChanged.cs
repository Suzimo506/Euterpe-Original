namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnSliderValueChanged : Event
{
	[SerializeField]
	private Slider m_Slider; //Field offset: 0x70

	public OnSliderValueChanged() { }

	private void Listener(float value) { }

	protected virtual void OnEnter() { }

	protected virtual void OnExit() { }

}


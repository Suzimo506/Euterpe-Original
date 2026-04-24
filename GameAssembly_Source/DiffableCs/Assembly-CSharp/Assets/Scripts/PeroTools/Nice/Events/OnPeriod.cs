namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnPeriod : Event
{
	public float frequency; //Field offset: 0x70

	public OnPeriod() { }

	protected virtual void OnEnter() { }

	protected virtual void OnExit() { }

}


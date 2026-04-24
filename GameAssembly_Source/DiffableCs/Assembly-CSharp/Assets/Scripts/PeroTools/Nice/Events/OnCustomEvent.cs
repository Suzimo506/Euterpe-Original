namespace Assets.Scripts.PeroTools.Nice.Events;

public class OnCustomEvent : Event
{
	public string eventType; //Field offset: 0x70

	public OnCustomEvent() { }

	protected virtual void OnEnter() { }

	protected virtual void OnExit() { }

	private void Trigger(object sender, object reciever, Object[] args) { }

}


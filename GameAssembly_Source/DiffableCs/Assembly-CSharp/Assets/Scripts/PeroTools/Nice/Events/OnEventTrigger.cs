namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public class OnEventTrigger : Event
{
	[SerializeField]
	private EventTriggerType m_Type; //Field offset: 0x70
	private TriggerEvent m_EventCallback; //Field offset: 0x78

	public OnEventTrigger() { }

	protected virtual void OnEnter() { }

	private void OnEventTriggerExecute(BaseEventData eventData) { }

	protected virtual void OnExit() { }

}


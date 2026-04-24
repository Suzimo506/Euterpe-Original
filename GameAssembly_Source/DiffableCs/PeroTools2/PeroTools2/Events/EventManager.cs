namespace PeroTools2.Events;

public class EventManager : Singleton<EventManager>
{
	private Dictionary<UInt32, EventTrigger> m_EventTriggers; //Field offset: 0x10
	private Dictionary<UInt32, NoArgEventTrigger> m_NoArgEventTriggers; //Field offset: 0x18

	public EventManager() { }

	protected void AddTrigger(uint id, NoArgEventTrigger trigger) { }

	protected void AddTrigger(uint id, TTrigger trigger) { }

	private void Init() { }

	public void Invoke(uint id, IBaseValue value = null) { }

	public void Play(uint id) { }

	public void Play(uint id, TArg1 arg1, TArg2 arg2, TArg3 arg3) { }

	public void Play(uint id, TArg1 arg1, TArg2 arg2) { }

	public void Play(uint id, TArg arg) { }

	public EventTrigger RegEvent(uint id) { }

	public NoArgEventTrigger RegisterEvent(uint id) { }

	public ArgEventTrigger<TArg> RegisterEvent(uint id) { }

	public ArgEventTrigger<TArg1, TArg2> RegisterEvent(uint id) { }

	public ArgEventTrigger<TArg1, TArg2, TArg3> RegisterEvent(uint id) { }

	protected TTrigger RemoveTrigger(uint id) { }

	protected NoArgEventTrigger RemoveTrigger(uint id) { }

	protected bool TryGetTrigger(uint id, out TTrigger trigger) { }

	protected bool TryGetTrigger(uint id, out NoArgEventTrigger trigger) { }

	public EventTrigger UnregEvent(uint id) { }

	[Obsolete]
	public ArgEventTrigger<TArg1, TArg2> UnregisterEvent(uint id) { }

	[Obsolete]
	public ArgEventTrigger<TArg> UnregisterEvent(uint id) { }

	[Obsolete]
	public NoArgEventTrigger UnregisterEvent(uint id) { }

	[Obsolete]
	public ArgEventTrigger<TArg1, TArg2, TArg3> UnregisterEvent(uint id) { }

	public EventTrigger UnregisterEventUniversal(uint id) { }

}


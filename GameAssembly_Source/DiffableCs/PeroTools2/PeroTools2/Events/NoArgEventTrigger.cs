namespace PeroTools2.Events;

public sealed class NoArgEventTrigger : EventTrigger
{
	[CompilerGenerated]
	private Action action; //Field offset: 0x20

	public event Action action
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	internal NoArgEventTrigger(uint id) { }

	public NoArgEventTrigger Add(Action toAdd) { }

	[CompilerGenerated]
	public void add_action(Action value) { }

	public NoArgEventTrigger Clear() { }

	protected virtual void ClearEventsImpl() { }

	internal void Play() { }

	public NoArgEventTrigger Remove(Action toRemove) { }

	[CompilerGenerated]
	public void remove_action(Action value) { }

}


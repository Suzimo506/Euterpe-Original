namespace Assets.Scripts.Managers;

public class EventHandler : AbstractEventHandler
{
	[CompilerGenerated]
	private TriggerHandler<T> trigger; //Field offset: 0x0

	public event TriggerHandler<T> trigger
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	public EventHandler`1(string uid) { }

	[CompilerGenerated]
	public void add_trigger(TriggerHandler<T> value) { }

	internal EventHandler<T> Clear() { }

	public virtual void ClearEvent() { }

	internal void Play(T arg1) { }

	internal virtual void Play(Object[] args = null) { }

	[CompilerGenerated]
	public void remove_trigger(TriggerHandler<T> value) { }

}


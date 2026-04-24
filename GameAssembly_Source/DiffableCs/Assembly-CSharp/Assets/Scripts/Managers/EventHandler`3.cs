namespace Assets.Scripts.Managers;

public class EventHandler : AbstractEventHandler
{
	[CompilerGenerated]
	private TriggerHandler<T, T2, T3> trigger; //Field offset: 0x0

	public event TriggerHandler<T, T2, T3> trigger
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	public EventHandler`3(string uid) { }

	[CompilerGenerated]
	public void add_trigger(TriggerHandler<T, T2, T3> value) { }

	internal EventHandler<T, T2, T3> Clear() { }

	public virtual void ClearEvent() { }

	internal void Play(T arg1, T2 arg2, T3 arg3) { }

	internal virtual void Play(Object[] args = null) { }

	[CompilerGenerated]
	public void remove_trigger(TriggerHandler<T, T2, T3> value) { }

}


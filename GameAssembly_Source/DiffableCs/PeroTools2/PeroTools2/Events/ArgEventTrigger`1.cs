namespace PeroTools2.Events;

public sealed class ArgEventTrigger : EventTrigger
{
	[CompilerGenerated]
	private Action<TArg> action; //Field offset: 0x0

	public event Action<TArg> action
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	internal ArgEventTrigger`1(uint id) { }

	public ArgEventTrigger<TArg> Add(Action<TArg> toAdd) { }

	[CompilerGenerated]
	public void add_action(Action<TArg> value) { }

	public ArgEventTrigger<TArg> Clear() { }

	protected virtual void ClearEventsImpl() { }

	internal void Play(TArg value) { }

	public ArgEventTrigger<TArg> Remove(Action<TArg> toRemove) { }

	[CompilerGenerated]
	public void remove_action(Action<TArg> value) { }

}


namespace PeroTools2.Events;

public sealed class ArgEventTrigger : EventTrigger
{
	[CompilerGenerated]
	private Action<TArg1, TArg2> action; //Field offset: 0x0

	public event Action<TArg1, TArg2> action
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	internal ArgEventTrigger`2(uint id) { }

	public ArgEventTrigger<TArg1, TArg2> Add(Action<TArg1, TArg2> toAdd) { }

	[CompilerGenerated]
	public void add_action(Action<TArg1, TArg2> value) { }

	public ArgEventTrigger<TArg1, TArg2> Clear() { }

	protected virtual void ClearEventsImpl() { }

	internal void Play(TArg1 arg1, TArg2 arg2) { }

	public ArgEventTrigger<TArg1, TArg2> Remove(Action<TArg1, TArg2> toRemove) { }

	[CompilerGenerated]
	public void remove_action(Action<TArg1, TArg2> value) { }

}


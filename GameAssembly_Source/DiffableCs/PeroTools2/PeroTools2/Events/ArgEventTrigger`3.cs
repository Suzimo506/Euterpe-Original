namespace PeroTools2.Events;

public sealed class ArgEventTrigger : EventTrigger
{
	[CompilerGenerated]
	private Action<TArg1, TArg2, TArg3> action; //Field offset: 0x0

	public event Action<TArg1, TArg2, TArg3> action
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	internal ArgEventTrigger`3(uint id) { }

	public ArgEventTrigger<TArg1, TArg2, TArg3> Add(Action<TArg1, TArg2, TArg3> toAdd) { }

	[CompilerGenerated]
	public void add_action(Action<TArg1, TArg2, TArg3> value) { }

	public ArgEventTrigger<TArg1, TArg2, TArg3> Clear() { }

	protected virtual void ClearEventsImpl() { }

	internal void Play(TArg1 arg1, TArg2 arg2, TArg3 arg3) { }

	public ArgEventTrigger<TArg1, TArg2, TArg3> Remove(Action<TArg1, TArg2, TArg3> toRemove) { }

	[CompilerGenerated]
	public void remove_action(Action<TArg1, TArg2, TArg3> value) { }

}


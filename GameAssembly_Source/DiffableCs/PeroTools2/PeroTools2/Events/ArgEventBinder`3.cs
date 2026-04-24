namespace PeroTools2.Events;

public sealed class ArgEventBinder : EventBinder
{
	private readonly Action<TArg1, TArg2, TArg3> m_Action; //Field offset: 0x0

	[Obsolete]
	public ArgEventBinder`3(uint id, Action<TArg1, TArg2, TArg3> action) { }

	protected virtual void BindImpl(EventManager manager) { }

	protected virtual void UnbindImpl(EventManager manager) { }

}


namespace PeroTools2.Events;

public sealed class ArgEventBinder : EventBinder
{
	private readonly Action<TArg> m_Action; //Field offset: 0x0

	[Obsolete]
	public ArgEventBinder`1(uint id, Action<TArg> action) { }

	protected virtual void BindImpl(EventManager manager) { }

	protected virtual void UnbindImpl(EventManager manager) { }

}


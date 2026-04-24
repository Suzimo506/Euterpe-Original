namespace PeroTools2.Events;

public sealed class NoArgEventBinder : EventBinder
{
	private readonly Action m_Action; //Field offset: 0x18

	[Obsolete]
	public NoArgEventBinder(uint id, Action action) { }

	protected virtual void BindImpl(EventManager manager) { }

	protected virtual void UnbindImpl(EventManager manager) { }

}


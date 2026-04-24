namespace PeroTools2.Events;

public abstract class EventBinder
{
	protected readonly uint m_Id; //Field offset: 0x10

	protected EventBinder(uint id) { }

	internal void Bind(EventManager manager) { }

	protected abstract void BindImpl(EventManager manager) { }

	public static NoArgEventBinder Create(uint id, Action action) { }

	public static ArgEventBinder<TArg> Create(uint id, Action<TArg> action) { }

	public static ArgEventBinder<TArg1, TArg2> Create(uint id, Action<TArg1, TArg2> action) { }

	public static ArgEventBinder<TArg1, TArg2, TArg3> Create(uint id, Action<TArg1, TArg2, TArg3> action) { }

	internal void Unbind(EventManager manager) { }

	protected abstract void UnbindImpl(EventManager manager) { }

}


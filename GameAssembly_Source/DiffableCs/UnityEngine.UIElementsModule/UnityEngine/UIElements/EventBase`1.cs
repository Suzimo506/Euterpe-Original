namespace UnityEngine.UIElements;

public abstract class EventBase : EventBase
{
	private static readonly long s_TypeId; //Field offset: 0x0
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0
	private int m_RefCount; //Field offset: 0x0

	public virtual long eventTypeId
	{
		 get { } //Length: 184
	}

	private static EventBase`1() { }

	protected EventBase`1() { }

	internal virtual void Acquire() { }

	public virtual void Dispose() { }

	public virtual long get_eventTypeId() { }

	public static T GetPooled() { }

	internal static T GetPooled(EventBase e) { }

	protected virtual void Init() { }

	private static void ReleasePooled(T evt) { }

	public static long TypeId() { }

}


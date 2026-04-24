namespace UnityEngine.UIElements;

internal class EventCallbackRegistry
{
	private static readonly EventCallbackListPool s_ListPool; //Field offset: 0x0
	private EventCallbackList m_Callbacks; //Field offset: 0x10
	private EventCallbackList m_TemporaryCallbacks; //Field offset: 0x18
	private int m_IsInvoking; //Field offset: 0x20

	private static EventCallbackRegistry() { }

	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) { }

	public bool HasBubbleHandlers() { }

	public bool HasTrickleDownHandlers() { }

	public void InvokeCallbacks(EventBase evt) { }

	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

}


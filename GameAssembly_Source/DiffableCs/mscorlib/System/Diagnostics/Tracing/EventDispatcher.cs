namespace System.Diagnostics.Tracing;

internal class EventDispatcher
{
	internal readonly EventListener m_Listener; //Field offset: 0x10
	internal Boolean[] m_EventEnabled; //Field offset: 0x18
	internal bool m_activityFilteringEnabled; //Field offset: 0x20
	internal EventDispatcher m_Next; //Field offset: 0x28

	internal EventDispatcher(EventDispatcher next, Boolean[] eventEnabled, EventListener listener) { }

}


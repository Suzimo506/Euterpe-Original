namespace System.Diagnostics.Tracing;

public class EventListener
{
	private static readonly object s_EventSourceCreatedLock; //Field offset: 0x0
	internal static EventListener s_Listeners; //Field offset: 0x8
	internal static List<WeakReference> s_EventSources; //Field offset: 0x10
	private static bool s_CreatingListener; //Field offset: 0x18
	private static bool s_EventSourceShutdownRegistered; //Field offset: 0x19
	[CompilerGenerated]
	private EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated; //Field offset: 0x10
	[CompilerGenerated]
	private EventHandler<EventWrittenEventArgs> EventWritten; //Field offset: 0x18
	internal EventListener m_Next; //Field offset: 0x20
	internal ActivityFilter m_activityFilter; //Field offset: 0x28

	internal static object EventListenersLock
	{
		internal get { } //Length: 248
	}

	private static EventListener() { }

	internal static void AddEventSource(EventSource newEventSource) { }

	private static void DisposeOnShutdown(object sender, EventArgs e) { }

	internal static object get_EventListenersLock() { }

	protected private override void OnEventSourceCreated(EventSource eventSource) { }

	protected private override void OnEventWritten(EventWrittenEventArgs eventData) { }

}


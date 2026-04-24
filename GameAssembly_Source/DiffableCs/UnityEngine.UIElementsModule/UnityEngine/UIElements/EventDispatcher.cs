namespace UnityEngine.UIElements;

public sealed class EventDispatcher
{
	private struct DispatchContext
	{
		public uint m_GateCount; //Field offset: 0x0
		public Queue<EventRecord> m_Queue; //Field offset: 0x8

	}

	private struct EventRecord
	{
		public EventBase m_Event; //Field offset: 0x0
		public IPanel m_Panel; //Field offset: 0x8

	}

	private static readonly ObjectPool<Queue`1<EventRecord>> k_EventQueuePool; //Field offset: 0x0
	private List<IEventDispatchingStrategy> m_DispatchingStrategies; //Field offset: 0x10
	private Queue<EventRecord> m_Queue; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly PointerDispatchState <pointerState>k__BackingField; //Field offset: 0x20
	private uint m_GateCount; //Field offset: 0x28
	private Stack<DispatchContext> m_DispatchContexts; //Field offset: 0x30
	private bool m_Immediate; //Field offset: 0x38

	private bool dispatchImmediately
	{
		private get { } //Length: 21
	}

	internal PointerDispatchState pointerState
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static EventDispatcher() { }

	internal EventDispatcher() { }

	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	internal void CloseGate() { }

	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	private bool get_dispatchImmediately() { }

	[CompilerGenerated]
	internal PointerDispatchState get_pointerState() { }

	internal void OpenGate() { }

	private void ProcessEvent(EventBase evt, IPanel panel) { }

	private void ProcessEventQueue() { }

}


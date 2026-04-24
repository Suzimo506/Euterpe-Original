namespace UnityEngine.UIElements;

public abstract class EventBase : IDisposable
{
	[Flags]
	public enum EventPropagation
	{
		None = 0,
		Bubbles = 1,
		TricklesDown = 2,
		Cancellable = 4,
	}

	[Flags]
	private enum LifeCycleStatus
	{
		None = 0,
		PropagationStopped = 1,
		ImmediatePropagationStopped = 2,
		DefaultPrevented = 4,
		Dispatching = 8,
		Pooled = 16,
		IMGUIEventIsValid = 32,
		StopDispatch = 64,
		PropagateToIMGUI = 128,
		Dispatched = 512,
		Processed = 1024,
	}

	private static long s_LastTypeId; //Field offset: 0x0
	private static ulong s_NextEventId; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private long <timestamp>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ulong <eventId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ulong <triggerEventId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventPropagation <propagation>k__BackingField; //Field offset: 0x28
	private PropagationPaths m_Path; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEventHandler <leafTarget>k__BackingField; //Field offset: 0x40
	private IEventHandler m_Target; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly List<IEventHandler> <skipElements>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private PropagationPhase <propagationPhase>k__BackingField; //Field offset: 0x58
	private IEventHandler m_CurrentTarget; //Field offset: 0x60
	private Event m_ImguiEvent; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <originalMousePosition>k__BackingField; //Field offset: 0x70

	public bool bubbles
	{
		 get { } //Length: 10
	}

	public internal override IEventHandler currentTarget
	{
		 get { } //Length: 7
		internal set { } //Length: 301
	}

	public internal bool dispatch
	{
		 get { } //Length: 10
		internal set { } //Length: 23
	}

	private bool dispatched
	{
		private get { } //Length: 13
		private set { } //Length: 27
	}

	internal ulong eventId
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override long eventTypeId
	{
		 get { } //Length: 8
	}

	public Event imguiEvent
	{
		 get { } //Length: 16
		 set { } //Length: 213
	}

	private bool imguiEventIsValid
	{
		private get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isDefaultPrevented
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isImmediatePropagationStopped
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	public private bool isPropagationStopped
	{
		 get { } //Length: 10
		private set { } //Length: 25
	}

	internal IEventHandler leafTarget
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private LifeCycleStatus lifeCycleStatus
	{
		[CompilerGenerated]
		private get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector2 originalMousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal PropagationPaths path
	{
		internal get { } //Length: 230
		internal set { } //Length: 310
	}

	protected bool pooled
	{
		 get { } //Length: 10
		 set { } //Length: 25
	}

	internal bool processed
	{
		internal get { } //Length: 13
		private set { } //Length: 27
	}

	internal bool propagateToIMGUI
	{
		internal get { } //Length: 13
		internal set { } //Length: 27
	}

	internal EventPropagation propagation
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal PropagationPhase propagationPhase
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal List<IEventHandler> skipElements
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal bool stopDispatch
	{
		internal get { } //Length: 10
		internal set { } //Length: 25
	}

	public IEventHandler target
	{
		 get { } //Length: 7
		 set { } //Length: 62
	}

	private long timestamp
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool tricklesDown
	{
		 get { } //Length: 10
	}

	private ulong triggerEventId
	{
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private static EventBase() { }

	protected EventBase() { }

	internal abstract void Acquire() { }

	public abstract void Dispose() { }

	public bool get_bubbles() { }

	public override IEventHandler get_currentTarget() { }

	public bool get_dispatch() { }

	private bool get_dispatched() { }

	[CompilerGenerated]
	internal ulong get_eventId() { }

	public override long get_eventTypeId() { }

	public Event get_imguiEvent() { }

	private bool get_imguiEventIsValid() { }

	public bool get_isDefaultPrevented() { }

	public bool get_isImmediatePropagationStopped() { }

	public bool get_isPropagationStopped() { }

	[CompilerGenerated]
	internal IEventHandler get_leafTarget() { }

	[CompilerGenerated]
	private LifeCycleStatus get_lifeCycleStatus() { }

	[CompilerGenerated]
	public Vector2 get_originalMousePosition() { }

	internal PropagationPaths get_path() { }

	protected bool get_pooled() { }

	internal bool get_processed() { }

	internal bool get_propagateToIMGUI() { }

	[CompilerGenerated]
	internal EventPropagation get_propagation() { }

	[CompilerGenerated]
	public PropagationPhase get_propagationPhase() { }

	[CompilerGenerated]
	internal List<IEventHandler> get_skipElements() { }

	internal bool get_stopDispatch() { }

	public IEventHandler get_target() { }

	public bool get_tricklesDown() { }

	protected override void Init() { }

	private void LocalInit() { }

	internal void MarkReceivedByDispatcher() { }

	protected private override void PostDispatch(IPanel panel) { }

	[Obsolete]
	protected override void PostDispatch() { }

	protected private override void PreDispatch(IPanel panel) { }

	[Obsolete]
	protected override void PreDispatch() { }

	public void PreventDefault() { }

	protected static long RegisterEventType() { }

	internal override void set_currentTarget(IEventHandler value) { }

	internal void set_dispatch(bool value) { }

	private void set_dispatched(bool value) { }

	[CompilerGenerated]
	private void set_eventId(ulong value) { }

	protected void set_imguiEvent(Event value) { }

	private void set_imguiEventIsValid(bool value) { }

	private void set_isDefaultPrevented(bool value) { }

	private void set_isImmediatePropagationStopped(bool value) { }

	private void set_isPropagationStopped(bool value) { }

	[CompilerGenerated]
	private void set_leafTarget(IEventHandler value) { }

	[CompilerGenerated]
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	[CompilerGenerated]
	private void set_originalMousePosition(Vector2 value) { }

	internal void set_path(PropagationPaths value) { }

	protected void set_pooled(bool value) { }

	private void set_processed(bool value) { }

	internal void set_propagateToIMGUI(bool value) { }

	[CompilerGenerated]
	internal void set_propagation(EventPropagation value) { }

	[CompilerGenerated]
	internal void set_propagationPhase(PropagationPhase value) { }

	internal void set_stopDispatch(bool value) { }

	public void set_target(IEventHandler value) { }

	[CompilerGenerated]
	private void set_timestamp(long value) { }

	[CompilerGenerated]
	private void set_triggerEventId(ulong value) { }

	internal void SetTriggerEventId(ulong id) { }

	internal bool Skip(IEventHandler h) { }

	public void StopImmediatePropagation() { }

	public void StopPropagation() { }

}


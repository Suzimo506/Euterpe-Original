namespace UnityEngine.UIElements;

internal abstract class BaseVisualElementPanel : IPanel
{
	private float m_PixelsPerPoint; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <disposed>k__BackingField; //Field offset: 0x20
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0x28

	public abstract ContextType contextType
	{
		 get { } //Length: 0
	}

	public abstract EventDispatcher dispatcher
	{
		 get { } //Length: 0
	}

	internal bool disposed
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool duringLayoutPhase
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
	}

	public abstract int IMGUIContainersCount
	{
		 get { } //Length: 0
	}

	public abstract EventInterests IMGUIEventInterests
	{
		 get { } //Length: 0
	}

	public abstract ScriptableObject ownerObject
	{
		 get { } //Length: 0
	}

	internal float pixelsPerPoint
	{
		internal set { } //Length: 190
	}

	internal override RepaintData repaintData
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public abstract IMGUIContainer rootIMGUIContainer
	{
		 get { } //Length: 0
	}

	internal abstract uint version
	{
		internal get { } //Length: 0
	}

	public abstract VisualElement visualTree
	{
		 get { } //Length: 0
	}

	internal void ClearCachedElementUnderPointer(EventBase triggerEvent) { }

	internal void CommitElementUnderPointers() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract ContextType get_contextType() { }

	public abstract EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	internal bool get_disposed() { }

	[CompilerGenerated]
	internal bool get_duringLayoutPhase() { }

	public abstract FocusController get_focusController() { }

	public abstract int get_IMGUIContainersCount() { }

	public abstract EventInterests get_IMGUIEventInterests() { }

	public abstract ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	internal override RepaintData get_repaintData() { }

	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	internal abstract uint get_version() { }

	public abstract VisualElement get_visualTree() { }

	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	public abstract VisualElement Pick(Vector2 point) { }

	public abstract void Repaint(Event e) { }

	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	internal void set_pixelsPerPoint(float value) { }

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, EventBase triggerEvent) { }

	public abstract void ValidateLayout() { }

}


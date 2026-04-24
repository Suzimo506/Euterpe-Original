namespace UnityEngine.UIElements;

public abstract class MouseEventBase : EventBase<T>, IMouseEvent, IMouseEventInternal
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <localMousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <mouseDelta>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; //Field offset: 0x0

	public override int button
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public internal virtual IEventHandler currentTarget
	{
		 get { } //Length: 25
		internal set { } //Length: 211
	}

	internal Vector2 localMousePosition
	{
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public override EventModifiers modifiers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector2 mouseDelta
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Vector2 mousePosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override int pressedButtons
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	private override bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected MouseEventBase`1() { }

	[CompilerGenerated]
	public override int get_button() { }

	[CompilerGenerated]
	public override int get_clickCount() { }

	public virtual IEventHandler get_currentTarget() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	[CompilerGenerated]
	public override Vector2 get_mouseDelta() { }

	[CompilerGenerated]
	public override Vector2 get_mousePosition() { }

	[CompilerGenerated]
	public override int get_pressedButtons() { }

	public static T GetPooled(Event systemEvent) { }

	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }

	public static T GetPooled(IMouseEvent triggerEvent) { }

	protected static T GetPooled(IPointerEvent pointerEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	protected private virtual void PreDispatch(IPanel panel) { }

	[CompilerGenerated]
	protected void set_button(int value) { }

	[CompilerGenerated]
	protected void set_clickCount(int value) { }

	internal virtual void set_currentTarget(IEventHandler value) { }

	[CompilerGenerated]
	internal void set_localMousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

	[CompilerGenerated]
	protected void set_mouseDelta(Vector2 value) { }

	[CompilerGenerated]
	protected void set_mousePosition(Vector2 value) { }

	[CompilerGenerated]
	protected void set_pressedButtons(int value) { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }

	[CompilerGenerated]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }

}


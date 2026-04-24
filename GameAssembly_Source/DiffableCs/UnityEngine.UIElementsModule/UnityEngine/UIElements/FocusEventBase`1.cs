namespace UnityEngine.UIElements;

public abstract class FocusEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Focusable <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private FocusChangeDirection <direction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private FocusController <focusController>k__BackingField; //Field offset: 0x0

	private FocusChangeDirection direction
	{
		[CompilerGenerated]
		private set { } //Length: 15
	}

	protected private FocusController focusController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private override Focusable relatedTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	protected FocusEventBase`1() { }

	[CompilerGenerated]
	protected FocusController get_focusController() { }

	[CompilerGenerated]
	public override Focusable get_relatedTarget() { }

	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_direction(FocusChangeDirection value) { }

	[CompilerGenerated]
	private void set_focusController(FocusController value) { }

	[CompilerGenerated]
	private void set_relatedTarget(Focusable value) { }

}


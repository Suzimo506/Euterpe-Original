namespace UnityEngine.UIElements;

public abstract class PointerCaptureEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEventHandler <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <pointerId>k__BackingField; //Field offset: 0x0

	private int pointerId
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private IEventHandler relatedTarget
	{
		[CompilerGenerated]
		private set { } //Length: 12
	}

	protected PointerCaptureEventBase`1() { }

	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_pointerId(int value) { }

	[CompilerGenerated]
	private void set_relatedTarget(IEventHandler value) { }

}


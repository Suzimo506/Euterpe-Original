namespace UnityEngine.UIElements;

public class WheelEvent : MouseEventBase<WheelEvent>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector3 <delta>k__BackingField; //Field offset: 0xB8

	private Vector3 delta
	{
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public WheelEvent() { }

	public static WheelEvent GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_delta(Vector3 value) { }

}


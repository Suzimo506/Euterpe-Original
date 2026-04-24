namespace UnityEngine;

[VisibleToOtherModules]
internal struct EventInterests
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <wantsMouseMove>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; //Field offset: 0x1

	public bool wantsMouseEnterLeaveWindow
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool wantsMouseMove
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[CompilerGenerated]
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	public bool get_wantsMouseMove() { }

	public bool WantsEvent(EventType type) { }

}


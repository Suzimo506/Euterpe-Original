namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class InputTracking
{
	private enum TrackingStateEventType
	{
		NodeAdded = 0,
		NodeRemoved = 1,
		TrackingAcquired = 2,
		TrackingLost = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<XRNodeState> trackingAcquired; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<XRNodeState> trackingLost; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<XRNodeState> nodeAdded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<XRNodeState> nodeRemoved; //Field offset: 0x18

	private static InputTracking() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public static string GetNodeName(ulong uniqueId) { }

	public static void GetNodeStates(List<XRNodeState> nodeStates) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void GetNodeStates_Internal(List<XRNodeState> nodeStates) { }

	[RequiredByNativeCode]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

}


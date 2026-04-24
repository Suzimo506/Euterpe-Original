namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class InputDevices
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<InputDevice> deviceConnected; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<InputDevice> deviceDisconnected; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<InputDevice> deviceConfigChanged; //Field offset: 0x10

	[RequiredByNativeCode]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}


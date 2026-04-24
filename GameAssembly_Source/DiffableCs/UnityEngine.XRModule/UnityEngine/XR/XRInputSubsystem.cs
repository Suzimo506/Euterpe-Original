namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28

	public XRInputSubsystem() { }

	[RequiredByNativeCode]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}


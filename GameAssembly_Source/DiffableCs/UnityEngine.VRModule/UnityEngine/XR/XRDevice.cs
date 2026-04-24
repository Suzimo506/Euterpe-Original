namespace UnityEngine.XR;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class XRDevice
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<String> deviceLoaded; //Field offset: 0x2C927B4

	private static XRDevice() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void DisableAutoXRCameraTracking(Camera camera, bool disabled) { }

	[Obsolete]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static TrackingSpaceType GetTrackingSpaceType() { }

	[RequiredByNativeCode]
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

}


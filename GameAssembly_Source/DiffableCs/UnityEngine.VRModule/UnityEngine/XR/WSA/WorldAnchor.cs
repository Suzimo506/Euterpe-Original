namespace UnityEngine.XR.WSA;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class WorldAnchor : Component
{
	internal sealed class OnTrackingChangedDelegate : MulticastDelegate
	{

		public OnTrackingChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(WorldAnchor worldAnchor, bool located) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private OnTrackingChangedDelegate OnTrackingChanged; //Field offset: 0x18

	[RequiredByNativeCode]
	private static void Internal_TriggerEventOnTrackingLost(WorldAnchor worldAnchor, bool located) { }

}


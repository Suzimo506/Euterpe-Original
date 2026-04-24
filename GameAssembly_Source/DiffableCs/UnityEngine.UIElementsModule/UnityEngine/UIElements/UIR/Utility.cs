namespace UnityEngine.UIElements.UIR;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class Utility
{
	internal class GPUBuffer
	{
		private IntPtr buffer; //Field offset: 0x0

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<Boolean> GraphicsResourcesRecreate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action EngineUpdate; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action FlushPendingResources; //Field offset: 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; //Field offset: 0x18

	private static Utility() { }

	[RequiredByNativeCode]
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCode]
	internal static void RaiseFlushPendingResources() { }

	[RequiredByNativeCode]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

}


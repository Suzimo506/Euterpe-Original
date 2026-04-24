namespace UnityEngine.Rendering;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private IntPtr m_Ptr; //Field offset: 0x0

	internal ScriptableRenderContext(IntPtr ptr) { }

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock) { }

	private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, IntPtr renderTypes, IntPtr stateBlocks, int stateCount) { }

	private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, IntPtr renderTypes, IntPtr stateBlocks, int stateCount) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ScriptableRenderContext other) { }

	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	internal Camera GetCamera(int index) { }

	private Camera GetCamera_Internal(int index) { }

	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

	public virtual int GetHashCode() { }

	internal int GetNumberOfCameras() { }

	private int GetNumberOfCameras_Internal() { }

	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	[FreeFunction]
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

}


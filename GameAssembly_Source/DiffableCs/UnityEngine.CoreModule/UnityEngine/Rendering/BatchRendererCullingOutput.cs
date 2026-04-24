namespace UnityEngine.Rendering;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput
{
	public JobHandle cullingJobsFence; //Field offset: 0x0
	public Plane* cullingPlanes; //Field offset: 0x10
	public BatchVisibility* batchVisibility; //Field offset: 0x18
	public Int32* visibleIndices; //Field offset: 0x20
	public int cullingPlanesCount; //Field offset: 0x28
	public int batchVisibilityCount; //Field offset: 0x2C
	public int visibleIndicesCount; //Field offset: 0x30

}


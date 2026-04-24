namespace UnityEngine.Rendering;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	public NativeArray<BatchVisibility> batchVisibility; //Field offset: 0x10
	public NativeArray<Int32> visibleIndices; //Field offset: 0x20
	public readonly LODParameters lodParameters; //Field offset: 0x30

	public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<Int32> outVisibleIndices, LODParameters inLodParameters) { }

}


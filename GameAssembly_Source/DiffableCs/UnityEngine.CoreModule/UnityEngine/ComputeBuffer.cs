namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public ComputeBuffer(int count, int stride) { }

	internal ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	[FreeFunction]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	[FreeFunction]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunction]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void Release() { }

	public void SetData(Array data) { }

}


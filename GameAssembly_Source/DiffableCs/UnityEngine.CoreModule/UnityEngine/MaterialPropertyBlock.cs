namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MaterialPropertyBlock
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public MaterialPropertyBlock() { }

	private void Clear(bool keepMemory) { }

	public void Clear() { }

	[NativeMethod]
	private static IntPtr CreateImpl() { }

	[NativeMethod]
	private static void DestroyImpl(IntPtr mpb) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public void SetFloat(int nameID, float value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetFloatImpl(int name, float value) { }

	public void SetVector(int nameID, Vector4 value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetVectorImpl(int name, Vector4 value) { }

	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

}


namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethod]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

	[FreeFunction]
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	[NativeMethod]
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	[FreeFunction]
	public void SetVector(int nameID, Vector4 val) { }

	public void SetVector(string name, Vector4 val) { }

	private void SetVector_Injected(int nameID, ref Vector4 val) { }

}


namespace UnityEngine.PostProcessing;

public sealed class RenderTextureFactory : IDisposable
{
	private HashSet<RenderTexture> m_TemporaryRTs; //Field offset: 0x10

	public RenderTextureFactory() { }

	public override void Dispose() { }

	public RenderTexture Get(RenderTexture baseRenderTexture) { }

	public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = 2, RenderTextureReadWrite rw = 0, FilterMode filterMode = 1, TextureWrapMode wrapMode = 1, string name = "FactoryTempTexture") { }

	public void Release(RenderTexture rt) { }

	public void ReleaseAll() { }

}


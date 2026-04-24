namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public struct RenderGraphBuilder : IDisposable
{
	private RenderPass m_RenderPass; //Field offset: 0x0
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x8
	private bool m_Disposed; //Field offset: 0x10

	internal RenderGraphBuilder(RenderPass renderPass, RenderGraphResourceRegistry resources) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public void EnableAsyncCompute(bool value) { }

	public RenderGraphResource ReadTexture(in RenderGraphResource input) { }

	public void SetRenderFunc(RenderFunc<PassData> renderFunc) { }

	public RenderGraphMutableResource UseColorBuffer(in RenderGraphMutableResource input, int index) { }

	public RenderGraphMutableResource UseDepthBuffer(in RenderGraphMutableResource input, DepthAccess flags) { }

	public RenderGraphResource UseRendererList(in RenderGraphResource input) { }

	public RenderGraphMutableResource WriteTexture(in RenderGraphMutableResource input) { }

}


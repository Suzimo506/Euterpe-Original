namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public class RenderGraph
{
	public abstract class RenderPass
	{
		internal string name; //Field offset: 0x10
		internal int index; //Field offset: 0x18
		internal ProfilingSampler customSampler; //Field offset: 0x20
		internal List<RenderGraphResource> resourceReadList; //Field offset: 0x28
		internal List<RenderGraphMutableResource> resourceWriteList; //Field offset: 0x30
		internal List<RenderGraphResource> usedRendererListList; //Field offset: 0x38
		internal bool enableAsyncCompute; //Field offset: 0x40
		protected RenderGraphMutableResource[] m_ColorBuffers; //Field offset: 0x48
		protected RenderGraphMutableResource m_DepthBuffer; //Field offset: 0x50
		protected int m_MaxColorBufferIndex; //Field offset: 0x5C

		internal int colorBufferMaxIndex
		{
			internal get { } //Length: 4
		}

		internal RenderGraphMutableResource[] colorBuffers
		{
			internal get { } //Length: 5
		}

		internal RenderGraphMutableResource depthBuffer
		{
			internal get { } //Length: 19
		}

		protected RenderPass() { }

		internal void Clear() { }

		internal abstract void Execute(RenderGraphContext renderGraphContext) { }

		internal int get_colorBufferMaxIndex() { }

		internal RenderGraphMutableResource[] get_colorBuffers() { }

		internal RenderGraphMutableResource get_depthBuffer() { }

		internal RenderFunc<PassData> GetExecuteDelegate() { }

		internal abstract bool HasRenderFunc() { }

		internal abstract void Release(RenderGraphContext renderGraphContext) { }

		internal void SetColorBuffer(in RenderGraphMutableResource resource, int index) { }

		internal void SetDepthBuffer(in RenderGraphMutableResource resource, DepthAccess flags) { }

	}

	public sealed class RenderPass : RenderPass
	{
		internal PassData data; //Field offset: 0x0
		internal RenderFunc<PassData> renderFunc; //Field offset: 0x0

		public RenderPass`1() { }

		internal virtual void Execute(RenderGraphContext renderGraphContext) { }

		internal virtual bool HasRenderFunc() { }

		internal virtual void Release(RenderGraphContext renderGraphContext) { }

	}

	public static readonly int kMaxMRTCount; //Field offset: 0x0
	private RenderGraphResourceRegistry m_Resources; //Field offset: 0x10
	private RenderGraphObjectPool m_RenderGraphPool; //Field offset: 0x18
	private List<RenderPass> m_RenderPasses; //Field offset: 0x20
	private List<RenderGraphResource> m_RendererLists; //Field offset: 0x28
	private RenderGraphDebugParams m_DebugParameters; //Field offset: 0x30
	private RenderGraphLogger m_Logger; //Field offset: 0x38

	public bool enabled
	{
		 get { } //Length: 27
	}

	public RTHandleProperties rtHandleProperties
	{
		 get { } //Length: 58
	}

	private static RenderGraph() { }

	public RenderGraph(bool supportMSAA, MSAASamples initialSampleCount) { }

	private RenderGraph() { }

	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, ProfilingSampler sampler = null) { }

	public void Cleanup() { }

	private void ClearRenderPasses() { }

	public RenderGraphResource CreateRendererList(in RendererListDesc desc) { }

	public RenderGraphMutableResource CreateTexture(TextureDesc desc, int shaderProperty = 0) { }

	public RenderGraphMutableResource CreateTexture(in RenderGraphResource texture, int shaderProperty = 0) { }

	public void Execute(ScriptableRenderContext renderContext, CommandBuffer cmd, in RenderGraphExecuteParams parameters) { }

	public bool get_enabled() { }

	public RTHandleProperties get_rtHandleProperties() { }

	public TextureDesc GetTextureDesc(in RenderGraphResource texture) { }

	public RenderGraphMutableResource ImportTexture(RTHandle rt, int shaderProperty = 0) { }

	private void LogFrameInformation(int renderingWidth, int renderingHeight) { }

	private void LogRendererListsCreation() { }

	private void LogRenderPassBegin(in RenderPass pass) { }

	private void PostRenderPassExecute(int passIndex, in RenderPass pass, RenderGraphContext rgContext) { }

	private void PreRenderPassExecute(int passIndex, in RenderPass pass, RenderGraphContext rgContext) { }

	private void PreRenderPassSetRenderTargets(in RenderPass pass, RenderGraphContext rgContext) { }

	public void RegisterDebug() { }

	public void UnRegisterDebug() { }

}


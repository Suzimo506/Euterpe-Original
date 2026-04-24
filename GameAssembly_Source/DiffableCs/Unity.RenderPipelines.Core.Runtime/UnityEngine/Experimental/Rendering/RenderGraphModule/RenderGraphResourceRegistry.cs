namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

public class RenderGraphResourceRegistry
{
	public struct RendererListResource
	{
		public RendererListDesc desc; //Field offset: 0x0
		public RendererList rendererList; //Field offset: 0xC0

		internal RendererListResource(in RendererListDesc desc) { }

	}

	public struct TextureResource
	{
		public TextureDesc desc; //Field offset: 0x0
		public bool imported; //Field offset: 0x70
		public RTHandle rt; //Field offset: 0x78
		public int cachedHash; //Field offset: 0x80
		public int firstWritePassIndex; //Field offset: 0x84
		public int lastReadPassIndex; //Field offset: 0x88
		public int shaderProperty; //Field offset: 0x8C
		public bool wasReleased; //Field offset: 0x90

		internal TextureResource(RTHandle rt, int shaderProperty) { }

		internal TextureResource(in TextureDesc desc, int shaderProperty) { }

		private void Reset() { }

	}

	private static readonly ShaderTagId s_EmptyName; //Field offset: 0x0
	private DynamicArray<TextureResource> m_TextureResources; //Field offset: 0x10
	private Dictionary<Int32, Stack`1<RTHandle>> m_TexturePool; //Field offset: 0x18
	private DynamicArray<RendererListResource> m_RendererListResources; //Field offset: 0x20
	private RTHandleSystem m_RTHandleSystem; //Field offset: 0x28
	private RenderGraphDebugParams m_RenderGraphDebug; //Field offset: 0x30
	private RenderGraphLogger m_Logger; //Field offset: 0x38
	private List<ValueTuple`2<Int32, RTHandle>> m_AllocatedTextures; //Field offset: 0x40

	private static RenderGraphResourceRegistry() { }

	private RenderGraphResourceRegistry() { }

	internal RenderGraphResourceRegistry(bool supportMSAA, MSAASamples initialSampleCount, RenderGraphDebugParams renderGraphDebug, RenderGraphLogger logger) { }

	internal void Cleanup() { }

	internal void Clear() { }

	internal void CreateAndClearTexturesForPass(RenderGraphContext rgContext, int passIndex, List<RenderGraphMutableResource> textures) { }

	internal RenderGraphResource CreateRendererList(in RendererListDesc desc) { }

	internal void CreateRendererLists(List<RenderGraphResource> rendererLists) { }

	internal RenderGraphMutableResource CreateTexture(in TextureDesc desc, int shaderProperty = 0) { }

	private void CreateTextureForPass(ref TextureResource resource) { }

	public RendererList GetRendererList(in RenderGraphResource handle) { }

	internal RTHandleProperties GetRTHandleProperties() { }

	public RTHandle GetTexture(in RenderGraphResource handle) { }

	private TextureResource GetTextureResource(RenderGraphResource res) { }

	internal TextureDesc GetTextureResourceDesc(RenderGraphResource res) { }

	internal RenderGraphMutableResource ImportTexture(RTHandle rt, int shaderProperty = 0) { }

	private void LogResources() { }

	private void LogTextureCreation(RTHandle rt, bool cleared) { }

	private void LogTextureRelease(RTHandle rt) { }

	internal void PostRenderPassUnbindGlobalTextures(RenderGraphContext rgContext, List<RenderGraphResource> textures) { }

	internal void PreRenderPassSetGlobalTextures(RenderGraphContext rgContext, List<RenderGraphResource> textures) { }

	private void ReleaseTextureForPass(RenderGraphResource res) { }

	private void ReleaseTextureResource(int hash, RTHandle rt) { }

	internal void ReleaseTexturesForPass(RenderGraphContext rgContext, int passIndex, List<RenderGraphResource> readTextures, List<RenderGraphMutableResource> writtenTextures) { }

	private void SetGlobalTextures(RenderGraphContext rgContext, List<RenderGraphResource> textures, bool bindDummyTexture) { }

	internal void SetRTHandleReferenceSize(int width, int height, MSAASamples msaaSamples) { }

	private bool TryGetRenderTarget(int hashCode, out RTHandle rt) { }

	internal void UpdateTextureFirstWrite(RenderGraphResource tex, int passIndex) { }

	internal void UpdateTextureLastRead(RenderGraphResource tex, int passIndex) { }

	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	private void ValidateTextureDesc(in TextureDesc desc) { }

}


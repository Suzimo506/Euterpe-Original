namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ScriptableRenderer
{
	private static RenderTargetIdentifier[] m_ActiveColorAttachments; //Field offset: 0x0
	private static RenderTargetIdentifier m_ActiveDepthAttachment; //Field offset: 0x8
	private static bool m_InsideStereoRenderBlock; //Field offset: 0x30
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies; //Field offset: 0x38
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; //Field offset: 0x10
	private RenderTargetIdentifier m_CameraColorTarget; //Field offset: 0x18

	public RenderTargetIdentifier cameraColorTarget
	{
		 get { } //Length: 29
	}

	private static ScriptableRenderer() { }

	public void EnqueuePass(ScriptableRenderPass pass) { }

	public RenderTargetIdentifier get_cameraColorTarget() { }

	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension) { }

	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension) { }

}


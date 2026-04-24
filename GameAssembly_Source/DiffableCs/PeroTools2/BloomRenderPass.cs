//Type is in global namespace

public class BloomRenderPass : ScriptableRenderPass
{
	private enum PassEnum
	{
		Prefilter = 0,
		BlitWithDepth = 1,
		BlitUp = 2,
		BlurH = 3,
		BlurV = 4,
		Combine = 5,
	}

	private const string m_ProfilerTag = "Bloom Render Pass"; //Field offset: 0x0
	private ShaderTagId m_ShaderTagId; //Field offset: 0x68
	private Material m_BloomMaterial; //Field offset: 0x70
	private RenderTargetIdentifier m_Source; //Field offset: 0x78
	private RenderTargetIdentifier m_Destination; //Field offset: 0xA0
	private RenderTargetHandle m_TempCameraRt; //Field offset: 0xC8
	private RenderTargetHandle m_TempEmissiveRt; //Field offset: 0xCC
	private RenderTargetHandle[] m_RtDown; //Field offset: 0xD0
	private RenderTargetHandle[] m_RtUp; //Field offset: 0xD8
	private RenderTextureDescriptor m_CameraTextureDescriptor; //Field offset: 0xE0
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x118
	private bool m_IsNeedEmissive; //Field offset: 0x120
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x124
	private BloomSettings m_BloomSettings; //Field offset: 0x190
	private int m_DownMipCount; //Field offset: 0x198
	private int m_UpMipCount; //Field offset: 0x19C
	private readonly int m_BloomParamId; //Field offset: 0x1A0
	private Vector3 m_BloomParam; //Field offset: 0x1A4
	private readonly int m_BloomTexParamId; //Field offset: 0x1B0
	private readonly int m_TempCameraColorParamId; //Field offset: 0x1B4
	private readonly int m_BloomTextureParamId; //Field offset: 0x1B8
	private readonly String[] m_DownMipNames; //Field offset: 0x1C0
	private readonly String[] m_UpMipNames; //Field offset: 0x1C8

	public BloomRenderPass() { }

	private void Blur(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier dest, RenderTargetIdentifier temp) { }

	private void CleanBloomRT(CommandBuffer cmd) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	private void DoBloom(CommandBuffer cmd) { }

	private void DoEmissive(ScriptableRenderContext context, ref RenderingData renderingData, CommandBuffer cmd) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void InitBloomRT(CommandBuffer cmd) { }

	public void Setup(RenderTargetIdentifier source, RenderTargetIdentifier destination, BloomSettings setting) { }

}


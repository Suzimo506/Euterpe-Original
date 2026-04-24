namespace UnityEngine.PostProcessing;

public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
{
	private enum OcclusionSource
	{
		DepthTexture = 0,
		DepthNormalsTexture = 1,
		GBuffer = 2,
	}

	private static class Uniforms
	{
		internal static readonly int _Intensity; //Field offset: 0x0
		internal static readonly int _Radius; //Field offset: 0x4
		internal static readonly int _FogParams; //Field offset: 0x8
		internal static readonly int _Downsample; //Field offset: 0xC
		internal static readonly int _SampleCount; //Field offset: 0x10
		internal static readonly int _OcclusionTexture1; //Field offset: 0x14
		internal static readonly int _OcclusionTexture2; //Field offset: 0x18
		internal static readonly int _OcclusionTexture; //Field offset: 0x1C
		internal static readonly int _MainTex; //Field offset: 0x20
		internal static readonly int _TempRT; //Field offset: 0x24

		private static Uniforms() { }

	}

	private const string k_BlitShaderString = "Hidden/Post FX/Blit"; //Field offset: 0x0
	private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion"; //Field offset: 0x0
	private readonly RenderTargetIdentifier[] m_MRT; //Field offset: 0x20

	public virtual bool active
	{
		 get { } //Length: 98
	}

	private bool ambientOnlySupported
	{
		private get { } //Length: 177
	}

	private OcclusionSource occlusionSource
	{
		private get { } //Length: 236
	}

	public AmbientOcclusionComponent() { }

	public virtual bool get_active() { }

	private bool get_ambientOnlySupported() { }

	private OcclusionSource get_occlusionSource() { }

	public virtual CameraEvent GetCameraEvent() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual string GetName() { }

	public virtual void PopulateCommandBuffer(CommandBuffer cb) { }

}


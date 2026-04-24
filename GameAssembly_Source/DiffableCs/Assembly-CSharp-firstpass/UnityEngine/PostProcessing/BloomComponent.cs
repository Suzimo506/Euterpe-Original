namespace UnityEngine.PostProcessing;

public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
{
	private static class Uniforms
	{
		internal static readonly int _AutoExposure; //Field offset: 0x0
		internal static readonly int _Threshold; //Field offset: 0x4
		internal static readonly int _Curve; //Field offset: 0x8
		internal static readonly int _PrefilterOffs; //Field offset: 0xC
		internal static readonly int _SampleScale; //Field offset: 0x10
		internal static readonly int _BaseTex; //Field offset: 0x14
		internal static readonly int _BloomTex; //Field offset: 0x18
		internal static readonly int _Bloom_Settings; //Field offset: 0x1C
		internal static readonly int _Bloom_DirtTex; //Field offset: 0x20
		internal static readonly int _Bloom_DirtIntensity; //Field offset: 0x24

		private static Uniforms() { }

	}

	private const int k_MaxPyramidBlurLevel = 16; //Field offset: 0x0
	private readonly RenderTexture[] m_BlurBuffer1; //Field offset: 0x20
	private readonly RenderTexture[] m_BlurBuffer2; //Field offset: 0x28

	public virtual bool active
	{
		 get { } //Length: 98
	}

	public BloomComponent() { }

	public virtual bool get_active() { }

	public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure) { }

}


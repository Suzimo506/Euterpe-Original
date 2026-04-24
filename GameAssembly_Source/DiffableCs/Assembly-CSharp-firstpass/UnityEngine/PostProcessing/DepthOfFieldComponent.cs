namespace UnityEngine.PostProcessing;

public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
{
	private static class Uniforms
	{
		internal static readonly int _DepthOfFieldTex; //Field offset: 0x0
		internal static readonly int _DepthOfFieldCoCTex; //Field offset: 0x4
		internal static readonly int _Distance; //Field offset: 0x8
		internal static readonly int _LensCoeff; //Field offset: 0xC
		internal static readonly int _MaxCoC; //Field offset: 0x10
		internal static readonly int _RcpMaxCoC; //Field offset: 0x14
		internal static readonly int _RcpAspect; //Field offset: 0x18
		internal static readonly int _MainTex; //Field offset: 0x1C
		internal static readonly int _CoCTex; //Field offset: 0x20
		internal static readonly int _TaaParams; //Field offset: 0x24
		internal static readonly int _DepthOfFieldParams; //Field offset: 0x28

		private static Uniforms() { }

	}

	private const string k_ShaderString = "Hidden/Post FX/Depth Of Field"; //Field offset: 0x0
	private const float k_FilmHeight = 0.024; //Field offset: 0x0
	private RenderTexture m_CoCHistory; //Field offset: 0x20

	public virtual bool active
	{
		 get { } //Length: 86
	}

	public DepthOfFieldComponent() { }

	private float CalculateFocalLength() { }

	private float CalculateMaxCoCRadius(int screenHeight) { }

	private bool CheckHistory(int width, int height) { }

	public virtual bool get_active() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void OnDisable() { }

	public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending) { }

	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

}


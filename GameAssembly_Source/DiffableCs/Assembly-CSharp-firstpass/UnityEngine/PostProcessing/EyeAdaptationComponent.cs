namespace UnityEngine.PostProcessing;

public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
{
	private static class Uniforms
	{
		internal static readonly int _Params; //Field offset: 0x0
		internal static readonly int _Speed; //Field offset: 0x4
		internal static readonly int _ScaleOffsetRes; //Field offset: 0x8
		internal static readonly int _ExposureCompensation; //Field offset: 0xC
		internal static readonly int _AutoExposure; //Field offset: 0x10
		internal static readonly int _DebugWidth; //Field offset: 0x14

		private static Uniforms() { }

	}

	private static UInt32[] s_EmptyHistogramBuffer; //Field offset: 0x0
	private const int k_HistogramBins = 64; //Field offset: 0x0
	private const int k_HistogramThreadX = 16; //Field offset: 0x0
	private const int k_HistogramThreadY = 16; //Field offset: 0x0
	private ComputeShader m_EyeCompute; //Field offset: 0x20
	private ComputeBuffer m_HistogramBuffer; //Field offset: 0x28
	private readonly RenderTexture[] m_AutoExposurePool; //Field offset: 0x30
	private int m_AutoExposurePingPing; //Field offset: 0x38
	private RenderTexture m_CurrentAutoExposure; //Field offset: 0x40
	private RenderTexture m_DebugHistogram; //Field offset: 0x48
	private bool m_FirstFrame; //Field offset: 0x50

	public virtual bool active
	{
		 get { } //Length: 97
	}

	public EyeAdaptationComponent() { }

	public virtual bool get_active() { }

	private Vector4 GetHistogramScaleOffsetRes() { }

	public virtual void OnDisable() { }

	public virtual void OnEnable() { }

	public void OnGUI() { }

	public Texture Prepare(RenderTexture source, Material uberMaterial) { }

	public void ResetHistory() { }

}


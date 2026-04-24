namespace UnityEngine.PostProcessing;

public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
{
	private static class Uniforms
	{
		internal static int _Jitter; //Field offset: 0x0
		internal static int _SharpenParameters; //Field offset: 0x4
		internal static int _FinalBlendParameters; //Field offset: 0x8
		internal static int _HistoryTex; //Field offset: 0xC
		internal static int _MainTex; //Field offset: 0x10

		private static Uniforms() { }

	}

	private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing"; //Field offset: 0x0
	private const int k_SampleCount = 8; //Field offset: 0x0
	private readonly RenderBuffer[] m_MRT; //Field offset: 0x20
	private int m_SampleIndex; //Field offset: 0x28
	private bool m_ResetHistory; //Field offset: 0x2C
	private RenderTexture m_HistoryTexture; //Field offset: 0x30
	[CompilerGenerated]
	private Vector2 <jitterVector>k__BackingField; //Field offset: 0x38

	public virtual bool active
	{
		 get { } //Length: 117
	}

	public private Vector2 jitterVector
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public TaaComponent() { }

	private Vector2 GenerateRandomOffset() { }

	public virtual bool get_active() { }

	[CompilerGenerated]
	public Vector2 get_jitterVector() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	private float GetHaltonValue(int index, int radix) { }

	private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset) { }

	private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset) { }

	public virtual void OnDisable() { }

	public void Render(RenderTexture source, RenderTexture destination) { }

	public void ResetHistory() { }

	[CompilerGenerated]
	private void set_jitterVector(Vector2 value) { }

	public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc) { }

}


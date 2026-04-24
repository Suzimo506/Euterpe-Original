namespace UnityEngine.PostProcessing;

public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
{
	private static class Uniforms
	{
		internal static readonly int _LutParams; //Field offset: 0x0
		internal static readonly int _NeutralTonemapperParams1; //Field offset: 0x4
		internal static readonly int _NeutralTonemapperParams2; //Field offset: 0x8
		internal static readonly int _HueShift; //Field offset: 0xC
		internal static readonly int _Saturation; //Field offset: 0x10
		internal static readonly int _Contrast; //Field offset: 0x14
		internal static readonly int _Balance; //Field offset: 0x18
		internal static readonly int _Lift; //Field offset: 0x1C
		internal static readonly int _InvGamma; //Field offset: 0x20
		internal static readonly int _Gain; //Field offset: 0x24
		internal static readonly int _Slope; //Field offset: 0x28
		internal static readonly int _Power; //Field offset: 0x2C
		internal static readonly int _Offset; //Field offset: 0x30
		internal static readonly int _ChannelMixerRed; //Field offset: 0x34
		internal static readonly int _ChannelMixerGreen; //Field offset: 0x38
		internal static readonly int _ChannelMixerBlue; //Field offset: 0x3C
		internal static readonly int _Curves; //Field offset: 0x40
		internal static readonly int _LogLut; //Field offset: 0x44
		internal static readonly int _LogLut_Params; //Field offset: 0x48
		internal static readonly int _ExposureEV; //Field offset: 0x4C

		private static Uniforms() { }

	}

	private const int k_InternalLogLutSize = 32; //Field offset: 0x0
	private const int k_CurvePrecision = 128; //Field offset: 0x0
	private const float k_CurveStep = 0.0078125; //Field offset: 0x0
	private Texture2D m_GradingCurves; //Field offset: 0x20
	private Color[] m_pixels; //Field offset: 0x28

	public virtual bool active
	{
		 get { } //Length: 86
	}

	public ColorGradingComponent() { }

	private Vector3 CalculateColorBalance(float temperature, float tint) { }

	public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain) { }

	public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset) { }

	private Vector3 CIExyToLMS(float x, float y) { }

	private static Vector3 ClampVector(Vector3 v, float min, float max) { }

	private void GenerateLut() { }

	public virtual bool get_active() { }

	private TextureFormat GetCurveFormat() { }

	private Texture2D GetCurveTexture() { }

	public static Vector3 GetGainValue(Color gain) { }

	public static Vector3 GetGammaValue(Color gamma) { }

	public static Vector3 GetLiftValue(Color lift) { }

	private RenderTextureFormat GetLutFormat() { }

	public static Vector3 GetOffsetValue(Color offset) { }

	public static Vector3 GetPowerValue(Color power) { }

	public static Vector3 GetSlopeValue(Color slope) { }

	private bool IsLogLutValid(RenderTexture lut) { }

	private static Color NormalizeColor(Color c) { }

	public virtual void OnDisable() { }

	public void OnGUI() { }

	public virtual void Prepare(Material uberMaterial) { }

	private float StandardIlluminantY(float x) { }

}


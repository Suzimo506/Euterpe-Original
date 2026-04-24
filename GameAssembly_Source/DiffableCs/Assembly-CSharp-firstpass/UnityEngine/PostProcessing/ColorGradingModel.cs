namespace UnityEngine.PostProcessing;

public class ColorGradingModel : PostProcessingModel
{
	internal struct BasicSettings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float postExposure; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float temperature; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float tint; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float hueShift; //Field offset: 0xC
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float saturation; //Field offset: 0x10
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float contrast; //Field offset: 0x14

		public static BasicSettings defaultSettings
		{
			 get { } //Length: 27
		}

		public static BasicSettings get_defaultSettings() { }

	}

	internal struct ChannelMixerSettings
	{
		public Vector3 red; //Field offset: 0x0
		public Vector3 green; //Field offset: 0xC
		public Vector3 blue; //Field offset: 0x18
		[HideInInspector]
		public int currentEditingChannel; //Field offset: 0x24

		public static ChannelMixerSettings defaultSettings
		{
			 get { } //Length: 219
		}

		public static ChannelMixerSettings get_defaultSettings() { }

	}

	internal enum ColorWheelMode
	{
		Linear = 0,
		Log = 1,
	}

	internal struct ColorWheelsSettings
	{
		public ColorWheelMode mode; //Field offset: 0x0
		[TrackballGroup]
		public LogWheelsSettings log; //Field offset: 0x4
		[TrackballGroup]
		public LinearWheelsSettings linear; //Field offset: 0x34

		public static ColorWheelsSettings defaultSettings
		{
			 get { } //Length: 205
		}

		public static ColorWheelsSettings get_defaultSettings() { }

	}

	internal struct CurvesSettings
	{
		public ColorGradingCurve master; //Field offset: 0x0
		public ColorGradingCurve red; //Field offset: 0x8
		public ColorGradingCurve green; //Field offset: 0x10
		public ColorGradingCurve blue; //Field offset: 0x18
		public ColorGradingCurve hueVShue; //Field offset: 0x20
		public ColorGradingCurve hueVSsat; //Field offset: 0x28
		public ColorGradingCurve satVSsat; //Field offset: 0x30
		public ColorGradingCurve lumVSsat; //Field offset: 0x38
		[HideInInspector]
		public int e_CurrentEditingCurve; //Field offset: 0x40
		[HideInInspector]
		public bool e_CurveY; //Field offset: 0x44
		[HideInInspector]
		public bool e_CurveR; //Field offset: 0x45
		[HideInInspector]
		public bool e_CurveG; //Field offset: 0x46
		[HideInInspector]
		public bool e_CurveB; //Field offset: 0x47

		public static CurvesSettings defaultSettings
		{
			 get { } //Length: 2198
		}

		public static CurvesSettings get_defaultSettings() { }

	}

	internal struct LinearWheelsSettings
	{
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color lift; //Field offset: 0x0
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color gamma; //Field offset: 0x10
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color gain; //Field offset: 0x20

		public static LinearWheelsSettings defaultSettings
		{
			 get { } //Length: 88
		}

		public static LinearWheelsSettings get_defaultSettings() { }

	}

	internal struct LogWheelsSettings
	{
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color slope; //Field offset: 0x0
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color power; //Field offset: 0x10
		[Trackball(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color offset; //Field offset: 0x20

		public static LogWheelsSettings defaultSettings
		{
			 get { } //Length: 88
		}

		public static LogWheelsSettings get_defaultSettings() { }

	}

	internal struct Settings
	{
		public TonemappingSettings tonemapping; //Field offset: 0x0
		public BasicSettings basic; //Field offset: 0x1C
		public ChannelMixerSettings channelMixer; //Field offset: 0x34
		public ColorWheelsSettings colorWheels; //Field offset: 0x5C
		public CurvesSettings curves; //Field offset: 0xC0

		public static Settings defaultSettings
		{
			 get { } //Length: 655
		}

		public static Settings get_defaultSettings() { }

	}

	internal enum Tonemapper
	{
		None = 0,
		ACES = 1,
		Neutral = 2,
	}

	internal struct TonemappingSettings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Tonemapper tonemapper; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralBlackIn; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralWhiteIn; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralBlackOut; //Field offset: 0xC
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralWhiteOut; //Field offset: 0x10
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralWhiteLevel; //Field offset: 0x14
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float neutralWhiteClip; //Field offset: 0x18

		public static TonemappingSettings defaultSettings
		{
			 get { } //Length: 46
		}

		public static TonemappingSettings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isDirty>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private RenderTexture <bakedLut>k__BackingField; //Field offset: 0x128

	public internal RenderTexture bakedLut
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 15
	}

	public internal bool isDirty
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public Settings settings
	{
		 get { } //Length: 117
		 set { } //Length: 160
	}

	public ColorGradingModel() { }

	[CompilerGenerated]
	public RenderTexture get_bakedLut() { }

	[CompilerGenerated]
	public bool get_isDirty() { }

	public Settings get_settings() { }

	public virtual void OnValidate() { }

	public virtual void Reset() { }

	[CompilerGenerated]
	internal void set_bakedLut(RenderTexture value) { }

	[CompilerGenerated]
	internal void set_isDirty(bool value) { }

	public void set_settings(Settings value) { }

}


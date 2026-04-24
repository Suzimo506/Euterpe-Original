namespace UnityEngine.PostProcessing;

public class AntialiasingModel : PostProcessingModel
{
	internal struct FxaaConsoleSettings
	{
		public static FxaaConsoleSettings[] presets; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float subpixelSpreadAmount; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float edgeSharpnessAmount; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float edgeDetectionThreshold; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float minimumRequiredLuminance; //Field offset: 0xC

		private static FxaaConsoleSettings() { }

	}

	internal enum FxaaPreset
	{
		ExtremePerformance = 0,
		Performance = 1,
		Default = 2,
		Quality = 3,
		ExtremeQuality = 4,
	}

	internal struct FxaaQualitySettings
	{
		public static FxaaQualitySettings[] presets; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float subpixelAliasingRemovalAmount; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float edgeDetectionThreshold; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float minimumRequiredLuminance; //Field offset: 0x8

		private static FxaaQualitySettings() { }

	}

	internal struct FxaaSettings
	{
		public FxaaPreset preset; //Field offset: 0x0

		public static FxaaSettings defaultSettings
		{
			 get { } //Length: 6
		}

		public static FxaaSettings get_defaultSettings() { }

	}

	internal enum Method
	{
		Fxaa = 0,
		Taa = 1,
	}

	internal struct Settings
	{
		public Method method; //Field offset: 0x0
		public FxaaSettings fxaaSettings; //Field offset: 0x4
		public TaaSettings taaSettings; //Field offset: 0x8

		public static Settings defaultSettings
		{
			 get { } //Length: 28
		}

		public static Settings get_defaultSettings() { }

	}

	internal struct TaaSettings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float jitterSpread; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float sharpen; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float stationaryBlending; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float motionBlending; //Field offset: 0xC

		public static TaaSettings defaultSettings
		{
			 get { } //Length: 31
		}

		public static TaaSettings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 21
		 set { } //Length: 18
	}

	public AntialiasingModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


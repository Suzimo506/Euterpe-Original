namespace UnityEngine.PostProcessing;

public class BuiltinDebugViewsModel : PostProcessingModel
{
	internal struct DepthSettings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float scale; //Field offset: 0x0

		public static DepthSettings defaultSettings
		{
			 get { } //Length: 7
		}

		public static DepthSettings get_defaultSettings() { }

	}

	internal enum Mode
	{
		None = 0,
		Depth = 1,
		Normals = 2,
		MotionVectors = 3,
		AmbientOcclusion = 4,
		EyeAdaptation = 5,
		FocusPlane = 6,
		PreGradingLog = 7,
		LogLut = 8,
		UserLut = 9,
	}

	internal struct MotionVectorsSettings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float sourceOpacity; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float motionImageOpacity; //Field offset: 0x4
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float motionImageAmplitude; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float motionVectorsOpacity; //Field offset: 0xC
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int motionVectorsResolution; //Field offset: 0x10
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float motionVectorsAmplitude; //Field offset: 0x14

		public static MotionVectorsSettings defaultSettings
		{
			 get { } //Length: 39
		}

		public static MotionVectorsSettings get_defaultSettings() { }

	}

	internal struct Settings
	{
		public Mode mode; //Field offset: 0x0
		public DepthSettings depth; //Field offset: 0x4
		public MotionVectorsSettings motionVectors; //Field offset: 0x8

		public static Settings defaultSettings
		{
			 get { } //Length: 81
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public bool willInterrupt
	{
		 get { } //Length: 28
	}

	public BuiltinDebugViewsModel() { }

	public Settings get_settings() { }

	public bool get_willInterrupt() { }

	public bool IsModeActive(Mode mode) { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


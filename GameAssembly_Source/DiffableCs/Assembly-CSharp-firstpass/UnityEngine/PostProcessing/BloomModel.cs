namespace UnityEngine.PostProcessing;

public class BloomModel : PostProcessingModel
{
	internal struct BloomSettings
	{
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x0
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float threshold; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float softKnee; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float radius; //Field offset: 0xC
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool antiFlicker; //Field offset: 0x10

		public static BloomSettings defaultSettings
		{
			 get { } //Length: 43
		}

		public float thresholdLinear
		{
			 get { } //Length: 96
			 set { } //Length: 100
		}

		public static BloomSettings get_defaultSettings() { }

		public float get_thresholdLinear() { }

		public void set_thresholdLinear(float value) { }

	}

	internal struct LensDirtSettings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Texture texture; //Field offset: 0x0
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x8

		public static LensDirtSettings defaultSettings
		{
			 get { } //Length: 41
		}

		public static LensDirtSettings get_defaultSettings() { }

	}

	internal struct Settings
	{
		public BloomSettings bloom; //Field offset: 0x0
		public LensDirtSettings lensDirt; //Field offset: 0x18

		public static Settings defaultSettings
		{
			 get { } //Length: 122
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 29
		 set { } //Length: 36
	}

	public BloomModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


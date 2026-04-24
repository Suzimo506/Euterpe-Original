namespace UnityEngine.PostProcessing;

public class AmbientOcclusionModel : PostProcessingModel
{
	internal enum SampleCount
	{
		Lowest = 3,
		Low = 6,
		Medium = 10,
		High = 16,
	}

	internal struct Settings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x0
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float radius; //Field offset: 0x4
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public SampleCount sampleCount; //Field offset: 0x8
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool downsampling; //Field offset: 0xC
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool forceForwardCompatibility; //Field offset: 0xD
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool ambientOnly; //Field offset: 0xE
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool highPrecision; //Field offset: 0xF

		public static Settings defaultSettings
		{
			 get { } //Length: 31
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public AmbientOcclusionModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


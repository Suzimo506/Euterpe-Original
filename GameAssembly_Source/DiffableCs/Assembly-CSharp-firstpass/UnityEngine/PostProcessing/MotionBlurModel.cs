namespace UnityEngine.PostProcessing;

public class MotionBlurModel : PostProcessingModel
{
	internal struct Settings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float shutterAngle; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int sampleCount; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float frameBlending; //Field offset: 0x8

		public static Settings defaultSettings
		{
			 get { } //Length: 18
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

	public MotionBlurModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


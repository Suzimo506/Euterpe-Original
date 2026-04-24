namespace UnityEngine.PostProcessing;

public class GrainModel : PostProcessingModel
{
	internal struct Settings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool colored; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float size; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float luminanceContribution; //Field offset: 0xC

		public static Settings defaultSettings
		{
			 get { } //Length: 34
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

	public GrainModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


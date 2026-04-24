namespace UnityEngine.PostProcessing;

public class ChromaticAberrationModel : PostProcessingModel
{
	internal struct Settings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Texture2D spectralTexture; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x8

		public static Settings defaultSettings
		{
			 get { } //Length: 41
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 11
		 set { } //Length: 17
	}

	public ChromaticAberrationModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


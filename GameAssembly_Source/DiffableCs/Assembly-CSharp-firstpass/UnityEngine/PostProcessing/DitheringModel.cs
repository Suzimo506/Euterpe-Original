namespace UnityEngine.PostProcessing;

public class DitheringModel : PostProcessingModel
{
	internal struct Settings
	{

		public static Settings defaultSettings
		{
			 get { } //Length: 3
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public DitheringModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


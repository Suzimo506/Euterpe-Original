namespace UnityEngine.PostProcessing;

public class DepthOfFieldModel : PostProcessingModel
{
	internal enum KernelSize
	{
		Small = 0,
		Medium = 1,
		Large = 2,
		VeryLarge = 3,
	}

	internal struct Settings
	{
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float focusDistance; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float aperture; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float focalLength; //Field offset: 0x8
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool useCameraFov; //Field offset: 0xC
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public KernelSize kernelSize; //Field offset: 0x10

		public static Settings defaultSettings
		{
			 get { } //Length: 43
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 17
		 set { } //Length: 14
	}

	public DepthOfFieldModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


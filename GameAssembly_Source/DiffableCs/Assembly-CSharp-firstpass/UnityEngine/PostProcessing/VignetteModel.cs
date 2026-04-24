namespace UnityEngine.PostProcessing;

public class VignetteModel : PostProcessingModel
{
	internal enum Mode
	{
		Classic = 0,
		Masked = 1,
	}

	internal struct Settings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Mode mode; //Field offset: 0x0
		[ColorUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Color color; //Field offset: 0x4
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Vector2 center; //Field offset: 0x14
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x1C
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float smoothness; //Field offset: 0x20
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float roundness; //Field offset: 0x24
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public Texture mask; //Field offset: 0x28
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float opacity; //Field offset: 0x30
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool rounded; //Field offset: 0x34

		public static Settings defaultSettings
		{
			 get { } //Length: 184
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 37
		 set { } //Length: 44
	}

	public VignetteModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


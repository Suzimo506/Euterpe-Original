namespace UnityEngine.PostProcessing;

public class EyeAdaptationModel : PostProcessingModel
{
	internal enum EyeAdaptationType
	{
		Progressive = 0,
		Fixed = 1,
	}

	internal struct Settings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float lowPercent; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float highPercent; //Field offset: 0x4
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float minLuminance; //Field offset: 0x8
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float maxLuminance; //Field offset: 0xC
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float keyValue; //Field offset: 0x10
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool dynamicKeyValue; //Field offset: 0x14
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public EyeAdaptationType adaptationType; //Field offset: 0x18
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float speedUp; //Field offset: 0x1C
		[Min(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float speedDown; //Field offset: 0x20
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int logMin; //Field offset: 0x24
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int logMax; //Field offset: 0x28

		public static Settings defaultSettings
		{
			 get { } //Length: 82
		}

		public static Settings get_defaultSettings() { }

	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 35
		 set { } //Length: 32
	}

	public EyeAdaptationModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


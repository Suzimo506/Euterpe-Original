namespace UnityEngine.PostProcessing;

public class ScreenSpaceReflectionModel : PostProcessingModel
{
	internal struct IntensitySettings
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float reflectionMultiplier; //Field offset: 0x0
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float fadeDistance; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float fresnelFade; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float fresnelFadePower; //Field offset: 0xC

	}

	internal struct ReflectionSettings
	{
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public SSRReflectionBlendType blendType; //Field offset: 0x0
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public SSRResolution reflectionQuality; //Field offset: 0x4
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float maxDistance; //Field offset: 0x8
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int iterationCount; //Field offset: 0xC
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public int stepSize; //Field offset: 0x10
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float widthModifier; //Field offset: 0x14
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float reflectionBlur; //Field offset: 0x18
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public bool reflectBackfaces; //Field offset: 0x1C

	}

	internal struct ScreenEdgeMask
	{
		[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public float intensity; //Field offset: 0x0

	}

	internal struct Settings
	{
		public ReflectionSettings reflection; //Field offset: 0x0
		public IntensitySettings intensity; //Field offset: 0x20
		public ScreenEdgeMask screenEdgeMask; //Field offset: 0x30

		public static Settings defaultSettings
		{
			 get { } //Length: 150
		}

		public static Settings get_defaultSettings() { }

	}

	internal enum SSRReflectionBlendType
	{
		PhysicallyBased = 0,
		Additive = 1,
	}

	internal enum SSRResolution
	{
		High = 0,
		Low = 2,
	}

	[SerializeField]
	private Settings m_Settings; //Field offset: 0x18

	public Settings settings
	{
		 get { } //Length: 33
		 set { } //Length: 30
	}

	public ScreenSpaceReflectionModel() { }

	public Settings get_settings() { }

	public virtual void Reset() { }

	public void set_settings(Settings value) { }

}


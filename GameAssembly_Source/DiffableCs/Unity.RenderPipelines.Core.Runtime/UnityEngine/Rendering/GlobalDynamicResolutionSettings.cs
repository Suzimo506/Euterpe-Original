namespace UnityEngine.Rendering;

public struct GlobalDynamicResolutionSettings
{
	public bool enabled; //Field offset: 0x0
	public float maxPercentage; //Field offset: 0x4
	public float minPercentage; //Field offset: 0x8
	public DynamicResolutionType dynResType; //Field offset: 0xC
	public DynamicResUpscaleFilter upsampleFilter; //Field offset: 0xD
	public bool forceResolution; //Field offset: 0xE
	public float forcedPercentage; //Field offset: 0x10

	public static GlobalDynamicResolutionSettings NewDefault() { }

}


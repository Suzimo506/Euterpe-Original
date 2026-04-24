namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct LightData
{
	public int mainLightIndex; //Field offset: 0x0
	public int additionalLightsCount; //Field offset: 0x4
	public int maxPerObjectAdditionalLightsCount; //Field offset: 0x8
	public NativeArray<VisibleLight> visibleLights; //Field offset: 0x10
	public bool shadeAdditionalLightsPerVertex; //Field offset: 0x20
	public bool supportsMixedLighting; //Field offset: 0x21

}


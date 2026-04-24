namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct ShadowData
{
	public bool supportsMainLightShadows; //Field offset: 0x0
	public bool requiresScreenSpaceShadowResolve; //Field offset: 0x1
	public int mainLightShadowmapWidth; //Field offset: 0x4
	public int mainLightShadowmapHeight; //Field offset: 0x8
	public int mainLightShadowCascadesCount; //Field offset: 0xC
	public Vector3 mainLightShadowCascadesSplit; //Field offset: 0x10
	public bool supportsAdditionalLightShadows; //Field offset: 0x1C
	public int additionalLightsShadowmapWidth; //Field offset: 0x20
	public int additionalLightsShadowmapHeight; //Field offset: 0x24
	public bool supportsSoftShadows; //Field offset: 0x28
	public int shadowmapDepthBufferBits; //Field offset: 0x2C
	public List<Vector4> bias; //Field offset: 0x30

}


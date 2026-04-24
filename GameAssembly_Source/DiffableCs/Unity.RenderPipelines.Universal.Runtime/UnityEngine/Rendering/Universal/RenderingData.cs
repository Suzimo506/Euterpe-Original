namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RenderingData
{
	public CullingResults cullResults; //Field offset: 0x0
	public CameraData cameraData; //Field offset: 0x10
	public LightData lightData; //Field offset: 0x150
	public ShadowData shadowData; //Field offset: 0x178
	public PostProcessingData postProcessingData; //Field offset: 0x1B0
	public bool supportsDynamicBatching; //Field offset: 0x1B8
	public PerObjectData perObjectData; //Field offset: 0x1BC
	[Obsolete]
	public bool killAlphaInFinalBlit; //Field offset: 0x1C0
	public bool postProcessingEnabled; //Field offset: 0x1C1
	internal bool resolveFinalTarget; //Field offset: 0x1C2

}


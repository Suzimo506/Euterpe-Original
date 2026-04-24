namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct CameraData
{
	public Camera camera; //Field offset: 0x0
	public CameraRenderType renderType; //Field offset: 0x8
	public RenderTexture targetTexture; //Field offset: 0x10
	public RenderTextureDescriptor cameraTargetDescriptor; //Field offset: 0x18
	internal Matrix4x4 viewMatrix; //Field offset: 0x4C
	internal Matrix4x4 projectionMatrix; //Field offset: 0x8C
	internal Rect pixelRect; //Field offset: 0xCC
	internal int pixelWidth; //Field offset: 0xDC
	internal int pixelHeight; //Field offset: 0xE0
	internal float aspectRatio; //Field offset: 0xE4
	public float renderScale; //Field offset: 0xE8
	public bool clearDepth; //Field offset: 0xEC
	public bool isSceneViewCamera; //Field offset: 0xED
	public bool isDefaultViewport; //Field offset: 0xEE
	public bool isHdrEnabled; //Field offset: 0xEF
	public bool requiresDepthTexture; //Field offset: 0xF0
	public bool requiresOpaqueTexture; //Field offset: 0xF1
	public SortingCriteria defaultOpaqueSortFlags; //Field offset: 0xF4
	public bool isStereoEnabled; //Field offset: 0xF8
	internal int numberOfXRPasses; //Field offset: 0xFC
	internal bool isXRMultipass; //Field offset: 0x100
	public float maxShadowDistance; //Field offset: 0x104
	public bool postProcessEnabled; //Field offset: 0x108
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> captureActions; //Field offset: 0x110
	public LayerMask volumeLayerMask; //Field offset: 0x118
	public Transform volumeTrigger; //Field offset: 0x120
	public bool isStopNaNEnabled; //Field offset: 0x128
	public bool isDitheringEnabled; //Field offset: 0x129
	public AntialiasingMode antialiasing; //Field offset: 0x12C
	public AntialiasingQuality antialiasingQuality; //Field offset: 0x130
	internal ScriptableRenderer renderer; //Field offset: 0x138

}


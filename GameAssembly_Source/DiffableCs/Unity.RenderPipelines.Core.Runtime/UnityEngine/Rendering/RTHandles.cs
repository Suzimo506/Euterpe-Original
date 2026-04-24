namespace UnityEngine.Rendering;

public static class RTHandles
{
	private static RTHandleSystem s_DefaultInstance; //Field offset: 0x67F50

	public static int maxHeight
	{
		 get { } //Length: 99
	}

	public static int maxWidth
	{
		 get { } //Length: 99
	}

	public static RTHandleProperties rtHandleProperties
	{
		 get { } //Length: 128
	}

	private static RTHandles() { }

	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, string name = "") { }

	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = false, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, string name = "") { }

	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = false, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, string name = "") { }

	public static RTHandle Alloc(Texture tex) { }

	private static RTHandle Alloc(RTHandle tex) { }

	public static int get_maxHeight() { }

	public static int get_maxWidth() { }

	public static RTHandleProperties get_rtHandleProperties() { }

	public static void Initialize(int width, int height, bool scaledRTsupportsMSAA, MSAASamples scaledRTMSAASamples) { }

	public static void Release(RTHandle rth) { }

	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	public static void SetReferenceSize(int width, int height, MSAASamples msaaSamples) { }

}


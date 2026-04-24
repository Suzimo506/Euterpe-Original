namespace UnityEngine.Rendering;

public static class CoreUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Assembly, IEnumerable`1<Type>> <>9__75_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Type> <GetAllAssemblyTypes>b__75_0(Assembly t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__76
	{
		public static readonly <>c__76<T> <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__76_0; //Field offset: 0x0

		private static <>c__76`1() { }

		public <>c__76`1() { }

		internal bool <GetAllTypesDerivedFrom>b__76_0(Type t) { }

	}

	public static readonly Vector3[] lookAtList; //Field offset: 0x0
	public const int gameObjectMenuPriority = 10; //Field offset: 0x0
	public const int assetCreateMenuPriority2 = 241; //Field offset: 0x0
	public const int assetCreateMenuPriority1 = 230; //Field offset: 0x0
	public const int editMenuPriority4 = 353; //Field offset: 0x0
	public const int assetCreateMenuPriority3 = 300; //Field offset: 0x0
	public const int editMenuPriority2 = 331; //Field offset: 0x0
	public const int editMenuPriority1 = 320; //Field offset: 0x0
	public const int editMenuPriority3 = 342; //Field offset: 0x0
	public static readonly Vector3[] upVectorList; //Field offset: 0x8
	private static Cubemap m_BlackCubeTexture; //Field offset: 0x10
	private static Cubemap m_MagentaCubeTexture; //Field offset: 0x18
	private static CubemapArray m_MagentaCubeTextureArray; //Field offset: 0x20
	private static Cubemap m_WhiteCubeTexture; //Field offset: 0x28
	private static RenderTexture m_EmptyUAV; //Field offset: 0x30
	private static Texture3D m_BlackVolumeTexture; //Field offset: 0x38
	private static IEnumerable<Type> m_AssemblyTypes; //Field offset: 0x40

	public static Cubemap blackCubeTexture
	{
		 get { } //Length: 507
	}

	public static Texture3D blackVolumeTexture
	{
		 get { } //Length: 466
	}

	public static RenderTexture emptyUAV
	{
		 get { } //Length: 365
	}

	public static Cubemap magentaCubeTexture
	{
		 get { } //Length: 507
	}

	public static CubemapArray magentaCubeTextureArray
	{
		 get { } //Length: 552
	}

	public static Cubemap whiteCubeTexture
	{
		 get { } //Length: 507
	}

	private static CoreUtils() { }

	public static bool AreAnimatedMaterialsEnabled(Camera camera) { }

	public static bool ArePostProcessesEnabled(Camera camera) { }

	public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = false) { }

	public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor) { }

	public static Color ConvertLinearToActiveColorSpace(Color color) { }

	public static Color ConvertSRGBToActiveColorSpace(Color color) { }

	public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) { }

	public static Material CreateEngineMaterial(Shader shader) { }

	public static Material CreateEngineMaterial(string shaderPath) { }

	public static void Destroy(object obj) { }

	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	private static int FixupDepthSlice(int depthSlice, RTHandle buffer) { }

	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	public static Cubemap get_blackCubeTexture() { }

	public static Texture3D get_blackVolumeTexture() { }

	public static RenderTexture get_emptyUAV() { }

	public static Cubemap get_magentaCubeTexture() { }

	public static CubemapArray get_magentaCubeTextureArray() { }

	public static Cubemap get_whiteCubeTexture() { }

	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	public static IEnumerable<Type> GetAllTypesDerivedFrom() { }

	public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1) { }

	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1) { }

	private static string GetRenderTargetAutoName(int width, int height, int depth, string format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1) { }

	private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	public static bool HasFlag(T mask, T flag) { }

	public static bool IsSceneLightingDisabled(Camera camera) { }

	public static bool IsSceneViewFogEnabled(Camera camera) { }

	public static void SafeRelease(ComputeBuffer buffer) { }

	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	public static void SetKeyword(Material material, string keyword, bool state) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = 0) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) { }

	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) { }

	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = 0) { }

	public static void SetViewport(CommandBuffer cmd, RTHandle target) { }

	private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor) { }

	public static void Swap(ref T a, ref T b) { }

}


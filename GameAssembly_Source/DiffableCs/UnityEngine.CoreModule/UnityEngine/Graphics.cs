namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x6B360

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static GraphicsTier activeTier
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	private static Graphics() { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest) { }

	[FreeFunction]
	private static void Blit2(Texture source, RenderTexture dest) { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunction]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[FreeFunction]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	public static GraphicsTier get_activeTier() { }

	[FreeFunction]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[NativeMethod]
	private static void Internal_SetMRTSimple(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetMRTSimple_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	public static void set_activeTier(GraphicsTier value) { }

	public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer) { }

	internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

}


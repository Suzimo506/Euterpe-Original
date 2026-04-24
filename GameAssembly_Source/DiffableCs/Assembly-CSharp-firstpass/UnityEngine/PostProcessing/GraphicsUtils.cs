namespace UnityEngine.PostProcessing;

public static class GraphicsUtils
{
	private static Texture2D s_WhiteTexture; //Field offset: 0x0
	private static Mesh s_Quad; //Field offset: 0x8

	public static bool isLinearColorSpace
	{
		 get { } //Length: 22
	}

	public static Mesh quad
	{
		 get { } //Length: 1104
	}

	public static bool supportsDX11
	{
		 get { } //Length: 34
	}

	public static Texture2D whiteTexture
	{
		 get { } //Length: 339
	}

	public static void Blit(Material material, int pass) { }

	public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false) { }

	public static void Destroy(object obj) { }

	public static void Dispose() { }

	public static bool get_isLinearColorSpace() { }

	public static Mesh get_quad() { }

	public static bool get_supportsDX11() { }

	public static Texture2D get_whiteTexture() { }

}


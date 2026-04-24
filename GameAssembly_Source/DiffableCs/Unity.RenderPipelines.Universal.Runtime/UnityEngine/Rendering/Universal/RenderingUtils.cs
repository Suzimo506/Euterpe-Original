namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class RenderingUtils
{
	private static List<ShaderTagId> m_LegacyShaderPassNames; //Field offset: 0x0
	private static Mesh s_FullscreenMesh; //Field offset: 0x8
	private static Dictionary<RenderTextureFormat, Boolean> m_RenderTextureFormatSupport; //Field offset: 0x10

	public static Mesh fullscreenMesh
	{
		 get { } //Length: 1155
	}

	private static RenderingUtils() { }

	public static Mesh get_fullscreenMesh() { }

}


namespace UnityEngine.Rendering;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct ShaderKeyword
{
	internal int m_KeywordIndex; //Field offset: 0x0

	public ShaderKeyword(string keywordName) { }

	[FreeFunction]
	internal static int GetGlobalKeywordIndex(string keyword) { }

}


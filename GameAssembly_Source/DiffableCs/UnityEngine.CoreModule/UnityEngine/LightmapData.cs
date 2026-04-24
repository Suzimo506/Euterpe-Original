namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class LightmapData
{
	internal Texture2D m_Light; //Field offset: 0x10
	internal Texture2D m_Dir; //Field offset: 0x18
	internal Texture2D m_ShadowMask; //Field offset: 0x20

	public LightmapData() { }

}


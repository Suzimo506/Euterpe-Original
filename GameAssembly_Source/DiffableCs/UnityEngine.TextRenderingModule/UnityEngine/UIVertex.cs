namespace UnityEngine;

[UsedByNativeCode]
public struct UIVertex
{
	private static readonly Color32 s_DefaultColor; //Field offset: 0x0
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x4
	public static UIVertex simpleVert; //Field offset: 0x14
	public Vector3 position; //Field offset: 0x0
	public Vector3 normal; //Field offset: 0xC
	public Vector4 tangent; //Field offset: 0x18
	public Color32 color; //Field offset: 0x28
	public Vector2 uv0; //Field offset: 0x2C
	public Vector2 uv1; //Field offset: 0x34
	public Vector2 uv2; //Field offset: 0x3C
	public Vector2 uv3; //Field offset: 0x44

	private static UIVertex() { }

}


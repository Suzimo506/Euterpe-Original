namespace UnityEngine;

[NativeClass(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class CanvasRenderer : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isMask>k__BackingField; //Field offset: 0x18

	public int absoluteDepth
	{
		 get { } //Length: 51
	}

	public Vector2 clippingSoftness
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	[NativeProperty]
	public bool cull
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool cullTransparentMesh
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool hasMoved
	{
		 get { } //Length: 51
	}

	public bool hasPopInstruction
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool hasRectClipping
	{
		 get { } //Length: 51
	}

	[Obsolete]
	public bool isMask
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int materialCount
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int popMaterialCount
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public int relativeDepth
	{
		 get { } //Length: 51
	}

	public CanvasRenderer() { }

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	public void Clear() { }

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	public void DisableRectClipping() { }

	public void EnableRectClipping(Rect rect) { }

	private void EnableRectClipping_Injected(ref Rect rect) { }

	public int get_absoluteDepth() { }

	public Vector2 get_clippingSoftness() { }

	private void get_clippingSoftness_Injected(out Vector2 ret) { }

	public bool get_cull() { }

	public bool get_cullTransparentMesh() { }

	public bool get_hasMoved() { }

	public bool get_hasPopInstruction() { }

	public bool get_hasRectClipping() { }

	[CompilerGenerated]
	public bool get_isMask() { }

	public int get_materialCount() { }

	public int get_popMaterialCount() { }

	public int get_relativeDepth() { }

	public float GetAlpha() { }

	public Color GetColor() { }

	private void GetColor_Injected(out Color ret) { }

	public float GetInheritedAlpha() { }

	public Material GetMaterial() { }

	public Material GetMaterial(int index) { }

	public Material GetPopMaterial(int index) { }

	public void set_clippingSoftness(Vector2 value) { }

	private void set_clippingSoftness_Injected(ref Vector2 value) { }

	public void set_cull(bool value) { }

	public void set_cullTransparentMesh(bool value) { }

	public void set_hasPopInstruction(bool value) { }

	[CompilerGenerated]
	public void set_isMask(bool value) { }

	public void set_materialCount(int value) { }

	public void set_popMaterialCount(int value) { }

	public void SetAlpha(float alpha) { }

	public void SetAlphaTexture(Texture texture) { }

	public void SetColor(Color color) { }

	private void SetColor_Injected(ref Color color) { }

	public void SetMaterial(Material material, Texture texture) { }

	public void SetMaterial(Material material, int index) { }

	public void SetMesh(Mesh mesh) { }

	public void SetPopMaterial(Material material, int index) { }

	public void SetTexture(Texture texture) { }

	[Obsolete]
	public void SetVertices(UIVertex[] vertices, int size) { }

	[Obsolete]
	public void SetVertices(List<UIVertex> vertices) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

}


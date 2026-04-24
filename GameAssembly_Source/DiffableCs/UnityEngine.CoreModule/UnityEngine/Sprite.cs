namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeType]
public sealed class Sprite : object
{

	public Texture2D associatedAlphaSplitTexture
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Vector4 border
	{
		 get { } //Length: 75
	}

	public Bounds bounds
	{
		 get { } //Length: 81
	}

	public bool packed
	{
		 get { } //Length: 57
	}

	public SpritePackingMode packingMode
	{
		 get { } //Length: 51
	}

	public SpritePackingRotation packingRotation
	{
		 get { } //Length: 51
	}

	public Vector2 pivot
	{
		[NativeMethod]
		 get { } //Length: 70
	}

	public float pixelsPerUnit
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Rect rect
	{
		 get { } //Length: 75
	}

	public float spriteAtlasTextureScale
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Texture2D texture
	{
		 get { } //Length: 51
	}

	public Rect textureRect
	{
		 get { } //Length: 207
	}

	public Vector2 textureRectOffset
	{
		 get { } //Length: 221
	}

	public UInt16[] triangles
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Vector2[] uv
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Vector2[] vertices
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	[RequiredByNativeCode]
	private Sprite() { }

	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	[FreeFunction]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	[FreeFunction]
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	private static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[NativeMethod]
	public Texture2D get_associatedAlphaSplitTexture() { }

	public Vector4 get_border() { }

	private void get_border_Injected(out Vector4 ret) { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_packed() { }

	public SpritePackingMode get_packingMode() { }

	public SpritePackingRotation get_packingRotation() { }

	[NativeMethod]
	public Vector2 get_pivot() { }

	private void get_pivot_Injected(out Vector2 ret) { }

	[NativeMethod]
	public float get_pixelsPerUnit() { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	[NativeMethod]
	public float get_spriteAtlasTextureScale() { }

	public Texture2D get_texture() { }

	public Rect get_textureRect() { }

	public Vector2 get_textureRectOffset() { }

	[FreeFunction]
	public UInt16[] get_triangles() { }

	[FreeFunction]
	public Vector2[] get_uv() { }

	[FreeFunction]
	public Vector2[] get_vertices() { }

	internal Vector4 GetInnerUVs() { }

	private void GetInnerUVs_Injected(out Vector4 ret) { }

	internal Vector4 GetOuterUVs() { }

	private void GetOuterUVs_Injected(out Vector4 ret) { }

	internal int GetPacked() { }

	internal int GetPackingMode() { }

	internal int GetPackingRotation() { }

	internal Vector4 GetPadding() { }

	private void GetPadding_Injected(out Vector4 ret) { }

	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	public int GetPhysicsShapeCount() { }

	[FreeFunction]
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	public int GetPhysicsShapePointCount(int shapeIdx) { }

	internal Rect GetTextureRect() { }

	private void GetTextureRect_Injected(out Rect ret) { }

	internal Vector2 GetTextureRectOffset() { }

	private void GetTextureRectOffset_Injected(out Vector2 ret) { }

	[NativeMethod]
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	[FreeFunction]
	public void OverrideGeometry(Vector2[] vertices, UInt16[] triangles) { }

	[FreeFunction]
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	[FreeFunction]
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

}


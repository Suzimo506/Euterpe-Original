namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public sealed class Mesh : object
{

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Matrix4x4[] bindposes
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int blendShapeCount
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public BoneWeight[] boneWeights
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Bounds bounds
	{
		 get { } //Length: 81
		 set { } //Length: 66
	}

	internal bool canAccess
	{
		[NativeMethod]
		internal get { } //Length: 51
	}

	public Color[] colors
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Color32[] colors32
	{
		 get { } //Length: 75
		 set { } //Length: 92
	}

	public IndexFormat indexFormat
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool isReadable
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Vector3[] normals
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public int subMeshCount
	{
		[NativeMethod]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public Vector4[] tangents
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Int32[] triangles
	{
		 get { } //Length: 155
		 set { } //Length: 246
	}

	public Vector2[] uv
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv2
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv3
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv4
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv5
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv6
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv7
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public Vector2[] uv8
	{
		 get { } //Length: 61
		 set { } //Length: 76
	}

	public int vertexAttributeCount
	{
		 get { } //Length: 51
	}

	public int vertexBufferCount
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int vertexCount
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public Vector3[] vertices
	{
		 get { } //Length: 58
		 set { } //Length: 73
	}

	[RequiredByNativeCode]
	public Mesh() { }

	[FreeFunction]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[ExcludeFromDocs]
	public void Clear() { }

	public void Clear(bool keepVertexLayout) { }

	[FreeFunction]
	public void ClearBlendShapes() { }

	[NativeMethod]
	private void ClearImpl(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine) { }

	[FreeFunction]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[FreeFunction]
	internal static Mesh FromInstanceID(int id) { }

	public Matrix4x4[] get_bindposes() { }

	[NativeMethod]
	public int get_blendShapeCount() { }

	public BoneWeight[] get_boneWeights() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	[NativeMethod]
	internal bool get_canAccess() { }

	public Color[] get_colors() { }

	public Color32[] get_colors32() { }

	public IndexFormat get_indexFormat() { }

	[NativeMethod]
	public bool get_isReadable() { }

	public Vector3[] get_normals() { }

	[NativeMethod]
	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	public Int32[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	public Vector2[] get_uv3() { }

	public Vector2[] get_uv4() { }

	public Vector2[] get_uv5() { }

	public Vector2[] get_uv6() { }

	public Vector2[] get_uv7() { }

	public Vector2[] get_uv8() { }

	public int get_vertexAttributeCount() { }

	[FreeFunction]
	public int get_vertexBufferCount() { }

	[NativeMethod]
	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	[FreeFunction]
	private IntPtr GetAllBoneWeightsArray() { }

	[FreeFunction]
	private int GetAllBoneWeightsArraySize() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	[FreeFunction]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	public uint GetBaseVertex(int submesh) { }

	[FreeFunction]
	private uint GetBaseVertexImpl(int submesh) { }

	private int GetBindposeCount() { }

	public void GetBindposes(List<Matrix4x4> bindposes) { }

	[FreeFunction]
	private void GetBindposesNonAllocImpl(out Matrix4x4[] values) { }

	[FreeFunction]
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[FreeFunction]
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunction]
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[FreeFunction]
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunction]
	public string GetBlendShapeName(int shapeIndex) { }

	public NativeArray<Byte> GetBonesPerVertex() { }

	[FreeFunction]
	private IntPtr GetBonesPerVertexArray() { }

	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	[FreeFunction]
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunction]
	private void GetBoneWeightsNonAllocImpl(out BoneWeight[] values) { }

	public void GetColors(List<Color32> colors) { }

	public void GetColors(List<Color> colors) { }

	public uint GetIndexCount(int submesh) { }

	[FreeFunction]
	private uint GetIndexCountImpl(int submesh) { }

	public uint GetIndexStart(int submesh) { }

	[FreeFunction]
	private uint GetIndexStartImpl(int submesh) { }

	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	public void GetIndices(List<Int32> indices, int submesh) { }

	public void GetIndices(List<Int32> indices, int submesh, bool applyBaseVertex) { }

	public void GetIndices(List<UInt16> indices, int submesh, bool applyBaseVertex = true) { }

	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	[FreeFunction]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction]
	private void GetIndicesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction]
	private void GetIndicesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	[FreeFunction]
	public IntPtr GetNativeIndexBufferPtr() { }

	[FreeFunction]
	[NativeThrows]
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	public void GetNormals(List<Vector3> normals) { }

	[FreeFunction]
	public SubMeshDescriptor GetSubMesh(int index) { }

	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	public void GetTangents(List<Vector4> tangents) { }

	public MeshTopology GetTopology(int submesh) { }

	[FreeFunction]
	private MeshTopology GetTopologyImpl(int submesh) { }

	public Int32[] GetTriangles(int submesh) { }

	public void GetTriangles(List<UInt16> triangles, int submesh, bool applyBaseVertex = true) { }

	public void GetTriangles(List<Int32> triangles, int submesh) { }

	public void GetTriangles(List<Int32> triangles, int submesh, bool applyBaseVertex) { }

	public Int32[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[FreeFunction]
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunction]
	private Int32[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction]
	private void GetTrianglesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction]
	private void GetTrianglesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	internal VertexAttribute GetUVChannel(int uvIndex) { }

	[NativeMethod]
	public float GetUVDistributionMetric(int uvSetIndex) { }

	public void GetUVs(int channel, List<Vector2> uvs) { }

	public void GetUVs(int channel, List<Vector3> uvs) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[FreeFunction]
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) { }

	[FreeFunction]
	private int GetVertexAttributeCountImpl() { }

	[FreeFunction]
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[FreeFunction]
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	[FreeFunction]
	private Array GetVertexAttributesAlloc() { }

	[FreeFunction]
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[FreeFunction]
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	public void GetVertices(List<Vector3> vertices) { }

	[NativeMethod]
	private bool HasBoneWeights() { }

	[FreeFunction]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction]
	private static void Internal_Create(Mesh mono) { }

	[FreeFunction]
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	[FreeFunction]
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction]
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	public void MarkDynamic() { }

	[NativeMethod]
	private void MarkDynamicImpl() { }

	[NativeMethod]
	public void MarkModified() { }

	public void Optimize() { }

	[NativeMethod]
	private void OptimizeImpl() { }

	public void OptimizeIndexBuffers() { }

	[NativeMethod]
	private void OptimizeIndexBuffersImpl() { }

	public void OptimizeReorderVertexBuffer() { }

	[NativeMethod]
	private void OptimizeReorderVertexBufferImpl() { }

	[FreeFunction]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	public void RecalculateBounds() { }

	[NativeMethod]
	private void RecalculateBoundsImpl() { }

	public void RecalculateNormals() { }

	[NativeMethod]
	private void RecalculateNormalsImpl() { }

	public void RecalculateTangents() { }

	[NativeMethod]
	private void RecalculateTangentsImpl() { }

	public void set_bindposes(Matrix4x4[] value) { }

	public void set_boneWeights(BoneWeight[] value) { }

	public void set_bounds(Bounds value) { }

	private void set_bounds_Injected(ref Bounds value) { }

	public void set_colors(Color[] value) { }

	public void set_colors32(Color32[] value) { }

	public void set_indexFormat(IndexFormat value) { }

	public void set_normals(Vector3[] value) { }

	[FreeFunction]
	public void set_subMeshCount(int value) { }

	public void set_tangents(Vector4[] value) { }

	public void set_triangles(Int32[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_uv3(Vector2[] value) { }

	public void set_uv4(Vector2[] value) { }

	public void set_uv5(Vector2[] value) { }

	public void set_uv6(Vector2[] value) { }

	public void set_uv7(Vector2[] value) { }

	public void set_uv8(Vector2[] value) { }

	public void set_vertices(Vector3[] value) { }

	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values) { }

	[FreeFunction]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) { }

	public void SetBoneWeights(NativeArray<Byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunction]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	public void SetColors(Color[] inColors) { }

	public void SetColors(Color[] inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors) { }

	public void SetColors(List<Color32> inColors, int start, int length) { }

	public void SetColors(Color32[] inColors) { }

	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(List<Color> inColors) { }

	public void SetColors(NativeArray<T> inColors) { }

	public void SetColors(NativeArray<T> inColors, int start, int length) { }

	public void SetColors(Color32[] inColors, int start, int length) { }

	public void SetIndexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunction]
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh) { }

	[FreeFunction]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length) { }

	[FreeFunction]
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount) { }

	public void SetNormals(NativeArray<T> inNormals, int start, int length) { }

	public void SetNormals(NativeArray<T> inNormals) { }

	public void SetNormals(List<Vector3> inNormals) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetNormals(Vector3[] inNormals) { }

	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount) { }

	[FreeFunction]
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	public void SetTangents(NativeArray<T> inTangents) { }

	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	public void SetTangents(Vector4[] inTangents) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	public void SetTangents(NativeArray<T> inTangents, int start, int length) { }

	public void SetTriangles(List<UInt16> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<UInt16> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(UInt16[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	public void SetTriangles(UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh) { }

	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length) { }

	public void SetUVs(int channel, NativeArray<T> uvs) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	public void SetUVs(int channel, Vector4[] uvs) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	public void SetUVs(int channel, Vector3[] uvs) { }

	public void SetUVs(int channel, Vector2[] uvs) { }

	public void SetUVs(int channel, List<Vector3> uvs) { }

	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length) { }

	public void SetVertexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	[FreeFunction]
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetVertices(Vector3[] inVertices) { }

	public void SetVertices(NativeArray<T> inVertices) { }

	public void SetVertices(NativeArray<T> inVertices, int start, int length) { }

	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	[NativeMethod]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

}


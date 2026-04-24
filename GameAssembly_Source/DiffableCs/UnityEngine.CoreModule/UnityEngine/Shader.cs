namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Shader : object
{

	internal DisableBatchingType disableBatching
	{
		[FreeFunction]
		internal get { } //Length: 51
	}

	[NativeProperty]
	public static int globalMaximumLOD
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static string globalRenderPipeline
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	[Obsolete]
	public static ShaderHardwareTier globalShaderHardwareTier
	{
		 get { } //Length: 72
		 set { } //Length: 79
	}

	public bool isSupported
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	[NativeProperty]
	public int maximumLOD
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int passCount
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int renderQueue
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	private Shader() { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	[FreeFunction]
	public static void DisableKeyword(string keyword) { }

	[FreeFunction]
	public static void EnableKeyword(string keyword) { }

	private static void ExtractGlobalFloatArray(int name, List<Single> values) { }

	[FreeFunction]
	private static void ExtractGlobalFloatArrayImpl(int name, out Single[] val) { }

	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction]
	private static void ExtractGlobalMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	[FreeFunction]
	private static void ExtractGlobalVectorArrayImpl(int name, out Vector4[] val) { }

	[FreeFunction]
	public static Shader Find(string name) { }

	[FreeFunction]
	internal static Shader FindBuiltin(string name) { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	public int FindPropertyIndex(string propertyName) { }

	[FreeFunction]
	internal DisableBatchingType get_disableBatching() { }

	public static int get_globalMaximumLOD() { }

	public static string get_globalRenderPipeline() { }

	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	[NativeMethod]
	public bool get_isSupported() { }

	public int get_maximumLOD() { }

	[FreeFunction]
	public int get_passCount() { }

	[FreeFunction]
	public int get_renderQueue() { }

	public Shader GetDependency(string name) { }

	public static Color GetGlobalColor(int nameID) { }

	public static Color GetGlobalColor(string name) { }

	public static float GetGlobalFloat(int nameID) { }

	public static float GetGlobalFloat(string name) { }

	public static Single[] GetGlobalFloatArray(string name) { }

	public static void GetGlobalFloatArray(int nameID, List<Single> values) { }

	public static void GetGlobalFloatArray(string name, List<Single> values) { }

	public static Single[] GetGlobalFloatArray(int nameID) { }

	[FreeFunction]
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunction]
	private static Single[] GetGlobalFloatArrayImpl(int name) { }

	[FreeFunction]
	private static float GetGlobalFloatImpl(int name) { }

	public static int GetGlobalInt(string name) { }

	public static int GetGlobalInt(int nameID) { }

	public static Matrix4x4 GetGlobalMatrix(string name) { }

	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	[FreeFunction]
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunction]
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[FreeFunction]
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	public static Texture GetGlobalTexture(string name) { }

	public static Texture GetGlobalTexture(int nameID) { }

	[FreeFunction]
	private static Texture GetGlobalTextureImpl(int name) { }

	public static Vector4 GetGlobalVector(int nameID) { }

	public static Vector4 GetGlobalVector(string name) { }

	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	public static Vector4[] GetGlobalVectorArray(string name) { }

	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[FreeFunction]
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunction]
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[FreeFunction]
	private static Vector4 GetGlobalVectorImpl(int name) { }

	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	[FreeFunction]
	private static String[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	public String[] GetPropertyAttributes(int propertyIndex) { }

	public int GetPropertyCount() { }

	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	[FreeFunction]
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	private static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret) { }

	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	[FreeFunction]
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	public string GetPropertyDescription(int propertyIndex) { }

	[FreeFunction]
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	[FreeFunction]
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	public string GetPropertyName(int propertyIndex) { }

	public int GetPropertyNameId(int propertyIndex) { }

	[FreeFunction]
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	[FreeFunction]
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	[FreeFunction]
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	[FreeFunction]
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[FreeFunction]
	internal static string IDToTag(int name) { }

	[FreeFunction]
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunction]
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunction]
	public static int PropertyToID(string name) { }

	public static void set_globalMaximumLOD(int value) { }

	public static void set_globalRenderPipeline(string value) { }

	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	public void set_maximumLOD(int value) { }

	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[FreeFunction]
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[FreeFunction]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	public static void SetGlobalFloatArray(int nameID, Single[] values) { }

	public static void SetGlobalFloatArray(string name, Single[] values) { }

	public static void SetGlobalFloatArray(string name, List<Single> values) { }

	public static void SetGlobalFloatArray(int nameID, List<Single> values) { }

	private static void SetGlobalFloatArray(int name, Single[] values, int count) { }

	[FreeFunction]
	private static void SetGlobalFloatArrayImpl(int name, Single[] values, int count) { }

	[FreeFunction]
	private static void SetGlobalFloatImpl(int name, float value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalInt(int nameID, int value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	[FreeFunction]
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunction]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	[FreeFunction]
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	[FreeFunction]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunction]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	[FreeFunction]
	internal static int TagToID(string name) { }

	[FreeFunction]
	public static void WarmupAllShaders() { }

}


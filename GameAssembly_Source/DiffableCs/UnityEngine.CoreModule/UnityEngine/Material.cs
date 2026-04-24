namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Material : object
{

	public Color color
	{
		 get { } //Length: 195
		 set { } //Length: 178
	}

	public bool doubleSidedGI
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool enableInstancing
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MaterialGlobalIlluminationFlags globalIlluminationFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Texture mainTexture
	{
		 get { } //Length: 152
		 set { } //Length: 168
	}

	public Vector2 mainTextureOffset
	{
		 get { } //Length: 113
		 set { } //Length: 178
	}

	public Vector2 mainTextureScale
	{
		 get { } //Length: 113
		 set { } //Length: 178
	}

	public int passCount
	{
		 get { } //Length: 51
	}

	internal int rawRenderQueue
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal get { } //Length: 51
	}

	public int renderQueue
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 64
	}

	public Shader shader
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public String[] shaderKeywords
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public Material(string contents) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	public Material(Shader shader) { }

	public int ComputeCRC() { }

	[FreeFunction]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[Obsolete]
	public static Material Create(string scriptContents) { }

	[FreeFunction]
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction]
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	private void ExtractColorArray(int name, List<Color> values) { }

	[FreeFunction]
	private void ExtractColorArrayImpl(int name, out Color[] val) { }

	private void ExtractFloatArray(int name, List<Single> values) { }

	[FreeFunction]
	private void ExtractFloatArrayImpl(int name, out Single[] val) { }

	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction]
	private void ExtractMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private void ExtractVectorArray(int name, List<Vector4> values) { }

	[FreeFunction]
	private void ExtractVectorArrayImpl(int name, out Vector4[] val) { }

	public int FindPass(string passName) { }

	public Color get_color() { }

	public bool get_doubleSidedGI() { }

	public bool get_enableInstancing() { }

	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	public Texture get_mainTexture() { }

	public Vector2 get_mainTextureOffset() { }

	public Vector2 get_mainTextureScale() { }

	public int get_passCount() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal int get_rawRenderQueue() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_renderQueue() { }

	public Shader get_shader() { }

	public String[] get_shaderKeywords() { }

	public Color GetColor(string name) { }

	public Color GetColor(int nameID) { }

	public void GetColorArray(string name, List<Color> values) { }

	public Color[] GetColorArray(string name) { }

	public void GetColorArray(int nameID, List<Color> values) { }

	public Color[] GetColorArray(int nameID) { }

	[FreeFunction]
	private int GetColorArrayCountImpl(int name) { }

	[FreeFunction]
	private Color[] GetColorArrayImpl(int name) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color GetColorImpl(int name) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	internal static Material GetDefaultLineMaterial() { }

	internal static Material GetDefaultMaterial() { }

	internal static Material GetDefaultParticleMaterial() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(int nameID) { }

	public float GetFloat(string name) { }

	public void GetFloatArray(int nameID, List<Single> values) { }

	public void GetFloatArray(string name, List<Single> values) { }

	public Single[] GetFloatArray(int nameID) { }

	public Single[] GetFloatArray(string name) { }

	[FreeFunction]
	private int GetFloatArrayCountImpl(int name) { }

	[FreeFunction]
	private Single[] GetFloatArrayImpl(int name) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float GetFloatImpl(int name) { }

	public int GetInt(int nameID) { }

	public int GetInt(string name) { }

	public Matrix4x4 GetMatrix(int nameID) { }

	public Matrix4x4 GetMatrix(string name) { }

	public Matrix4x4[] GetMatrixArray(string name) { }

	public Matrix4x4[] GetMatrixArray(int nameID) { }

	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	[FreeFunction]
	private int GetMatrixArrayCountImpl(int name) { }

	[FreeFunction]
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Matrix4x4 GetMatrixImpl(int name) { }

	private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	public string GetPassName(int pass) { }

	[FreeFunction]
	private String[] GetShaderKeywords() { }

	[FreeFunction]
	public bool GetShaderPassEnabled(string passName) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public Texture GetTexture(int nameID) { }

	public Texture GetTexture(string name) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Texture GetTextureImpl(int name) { }

	public Vector2 GetTextureOffset(int nameID) { }

	public Vector2 GetTextureOffset(string name) { }

	public void GetTexturePropertyNameIDs(List<Int32> outNames) { }

	[FreeFunction]
	public Int32[] GetTexturePropertyNameIDs() { }

	[FreeFunction]
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	public void GetTexturePropertyNames(List<String> outNames) { }

	[FreeFunction]
	public String[] GetTexturePropertyNames() { }

	[FreeFunction]
	private void GetTexturePropertyNamesInternal(object outNames) { }

	public Vector2 GetTextureScale(string name) { }

	public Vector2 GetTextureScale(int nameID) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	public Vector4 GetVector(int nameID) { }

	public Vector4 GetVector(string name) { }

	public void GetVectorArray(int nameID, List<Vector4> values) { }

	public Vector4[] GetVectorArray(int nameID) { }

	public Vector4[] GetVectorArray(string name) { }

	public void GetVectorArray(string name, List<Vector4> values) { }

	[FreeFunction]
	private int GetVectorArrayCountImpl(int name) { }

	[FreeFunction]
	private Vector4[] GetVectorArrayImpl(int name) { }

	public bool HasProperty(string name) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool HasProperty(int nameID) { }

	public bool IsKeywordEnabled(string keyword) { }

	[FreeFunction]
	[NativeThrows]
	public void Lerp(Material start, Material end, float t) { }

	public void set_color(Color value) { }

	public void set_doubleSidedGI(bool value) { }

	public void set_enableInstancing(bool value) { }

	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	public void set_mainTexture(Texture value) { }

	public void set_mainTextureOffset(Vector2 value) { }

	public void set_mainTextureScale(Vector2 value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void set_shaderKeywords(String[] value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetColor(string name, Color value) { }

	private void SetColorArray(int name, Color[] values, int count) { }

	public void SetColorArray(int nameID, Color[] values) { }

	public void SetColorArray(string name, Color[] values) { }

	public void SetColorArray(int nameID, List<Color> values) { }

	public void SetColorArray(string name, List<Color> values) { }

	[FreeFunction]
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloatArray(int nameID, Single[] values) { }

	public void SetFloatArray(string name, Single[] values) { }

	public void SetFloatArray(int nameID, List<Single> values) { }

	public void SetFloatArray(string name, List<Single> values) { }

	private void SetFloatArray(int name, Single[] values, int count) { }

	[FreeFunction]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetFloatImpl(int name, float value) { }

	public void SetInt(string name, int value) { }

	public void SetInt(int nameID, int value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	[FreeFunction]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public void SetOverrideTag(string tag, string val) { }

	[FreeFunction]
	public bool SetPass(int pass) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunction]
	private void SetShaderKeywords(String[] names) { }

	[FreeFunction]
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	public void SetTexture(string name, Texture value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetTextureOffset(int nameID, Vector2 value) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	public void SetTextureScale(string name, Vector2 value) { }

	public void SetTextureScale(int nameID, Vector2 value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVectorArray(string name, Vector4[] values) { }

	public void SetVectorArray(int nameID, List<Vector4> values) { }

	public void SetVectorArray(string name, List<Vector4> values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	[FreeFunction]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

}


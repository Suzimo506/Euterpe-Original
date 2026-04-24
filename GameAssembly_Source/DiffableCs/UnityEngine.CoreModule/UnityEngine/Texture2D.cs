namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D blackTexture
	{
		 get { } //Length: 42
	}

	public int calculatedMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int desiredMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public TextureFormat format
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D grayTexture
	{
		 get { } //Length: 42
	}

	internal bool isPreProcessed
	{
		internal get { } //Length: 51
	}

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D linearGrayTexture
	{
		 get { } //Length: 42
	}

	internal bool loadAllMips
	{
		[FreeFunction]
		internal get { } //Length: 51
		[FreeFunction]
		internal set { } //Length: 66
	}

	public int loadedMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int loadingMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public int minimumMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D normalTexture
	{
		 get { } //Length: 42
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D redTexture
	{
		 get { } //Length: 42
	}

	public int requestedMipmapLevel
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public bool streamingMipmaps
	{
		 get { } //Length: 51
	}

	public int streamingMipmapsPriority
	{
		 get { } //Length: 51
	}

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Texture2D whiteTexture
	{
		 get { } //Length: 42
	}

	public Texture2D(int width, int height) { }

	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply(bool updateMipmaps) { }

	public void Apply() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction]
	public void ClearMinimumMipmapLevel() { }

	[FreeFunction]
	public void ClearRequestedMipmapLevel() { }

	public void Compress(bool highQuality) { }

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	[FreeFunction]
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, out Rect[] rect) { }

	public static Texture2D get_blackTexture() { }

	[FreeFunction]
	public int get_calculatedMipmapLevel() { }

	[FreeFunction]
	public int get_desiredMipmapLevel() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TextureFormat get_format() { }

	public static Texture2D get_grayTexture() { }

	internal bool get_isPreProcessed() { }

	public virtual bool get_isReadable() { }

	public static Texture2D get_linearGrayTexture() { }

	[FreeFunction]
	internal bool get_loadAllMips() { }

	[FreeFunction]
	public int get_loadedMipmapLevel() { }

	[FreeFunction]
	public int get_loadingMipmapLevel() { }

	[FreeFunction]
	public int get_minimumMipmapLevel() { }

	public static Texture2D get_normalTexture() { }

	public static Texture2D get_redTexture() { }

	[FreeFunction]
	public int get_requestedMipmapLevel() { }

	public bool get_streamingMipmaps() { }

	public int get_streamingMipmapsPriority() { }

	public static Texture2D get_whiteTexture() { }

	public Color GetPixel(int x, int y, int mipLevel) { }

	public Color GetPixel(int x, int y) { }

	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	public Color GetPixelBilinear(float u, float v) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color GetPixelImpl(int image, int x, int y) { }

	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	public Color[] GetPixels() { }

	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunction]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	public Color[] GetPixels(int miplevel) { }

	[FreeFunction]
	public Color32[] GetPixels32(int miplevel) { }

	public Color32[] GetPixels32() { }

	private long GetRawImageDataSize() { }

	[FreeFunction]
	public Byte[] GetRawTextureData() { }

	public NativeArray<T> GetRawTextureData() { }

	private IntPtr GetWritableImageData(int frame) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction]
	public bool IsRequestedMipmapLevelLoaded() { }

	public void LoadRawTextureData(IntPtr data, int size) { }

	public void LoadRawTextureData(NativeArray<T> data) { }

	public void LoadRawTextureData(Byte[] data) { }

	[FreeFunction]
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	[FreeFunction]
	private bool LoadRawTextureDataImplArray(Byte[] data) { }

	[FreeFunction]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public bool Resize(int width, int height) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool ResizeImpl(int width, int height) { }

	[FreeFunction]
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunction]
	internal void set_loadAllMips(bool value) { }

	[FreeFunction]
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunction]
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunction]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	public void SetPixel(int x, int y, Color color) { }

	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	public void SetPixelData(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }

	[FreeFunction]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunction]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	public void SetPixels(Color[] colors) { }

	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	[FreeFunction]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction]
	public void UpdateExternalTexture(IntPtr nativeTex) { }

}


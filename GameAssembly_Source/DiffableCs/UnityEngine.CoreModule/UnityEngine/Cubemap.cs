namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Cubemap : Texture
{

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

	public virtual bool isReadable
	{
		 get { } //Length: 51
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

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCode]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	public void Apply() { }

	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction]
	public void ClearRequestedMipmapLevel() { }

	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	[FreeFunction]
	public int get_desiredMipmapLevel() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TextureFormat get_format() { }

	public virtual bool get_isReadable() { }

	[FreeFunction]
	internal bool get_loadAllMips() { }

	[FreeFunction]
	public int get_loadedMipmapLevel() { }

	[FreeFunction]
	public int get_loadingMipmapLevel() { }

	[FreeFunction]
	public int get_requestedMipmapLevel() { }

	public bool get_streamingMipmaps() { }

	public int get_streamingMipmapsPriority() { }

	public Color GetPixel(CubemapFace face, int x, int y) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color GetPixelImpl(int image, int x, int y) { }

	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	[FreeFunction]
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	public Color[] GetPixels(CubemapFace face) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction]
	public bool IsRequestedMipmapLevelLoaded() { }

	[FreeFunction]
	internal void set_loadAllMips(bool value) { }

	[FreeFunction]
	public void set_requestedMipmapLevel(int value) { }

	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	public void SetPixelData(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	[FreeFunction]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunction]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	public void SetPixels(Color[] colors, CubemapFace face) { }

	[FreeFunction]
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	public void SmoothEdges() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	[FreeFunction]
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

}


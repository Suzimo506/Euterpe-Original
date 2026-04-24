namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class CubemapArray : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCode]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply() { }

	[FreeFunction]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunction]
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunction]
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel) { }

	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement) { }

}


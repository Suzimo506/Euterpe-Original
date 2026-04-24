namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Texture3D : Texture
{

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCode]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	public void Apply() { }

	[FreeFunction]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunction]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunction]
	public void SetPixels(Color[] colors, int miplevel) { }

}


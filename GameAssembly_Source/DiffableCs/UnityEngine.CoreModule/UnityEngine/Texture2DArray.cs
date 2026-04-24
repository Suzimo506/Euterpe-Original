namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Texture2DArray : Texture
{

	public static int allSlices
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCode]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int get_allSlices() { }

	public virtual bool get_isReadable() { }

	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunction]
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

}


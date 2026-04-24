namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class Texture : object
{
	public static readonly int GenerateAllMips; //Field offset: 0x6B38C

	public int anisoLevel
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public override TextureDimension dimension
	{
		 get { } //Length: 51
		 set { } //Length: 73
	}

	public FilterMode filterMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public override int height
	{
		 get { } //Length: 51
		 set { } //Length: 73
	}

	public override bool isReadable
	{
		 get { } //Length: 51
	}

	public float mipMapBias
	{
		 set { } //Length: 67
	}

	public int mipmapCount
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public Vector2 texelSize
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 70
	}

	public override int width
	{
		 get { } //Length: 51
		 set { } //Length: 73
	}

	public TextureWrapMode wrapMode
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeU
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeV
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeW
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	public int get_anisoLevel() { }

	public override TextureDimension get_dimension() { }

	public FilterMode get_filterMode() { }

	public override int get_height() { }

	public override bool get_isReadable() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_mipmapCount() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Vector2 get_texelSize() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

	public override int get_width() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public TextureWrapMode get_wrapMode() { }

	public TextureWrapMode get_wrapModeU() { }

	public TextureWrapMode get_wrapModeV() { }

	public TextureWrapMode get_wrapModeW() { }

	private int GetDataHeight() { }

	private int GetDataWidth() { }

	private TextureDimension GetDimension() { }

	public void set_anisoLevel(int value) { }

	public override void set_dimension(TextureDimension value) { }

	public void set_filterMode(FilterMode value) { }

	public override void set_height(int value) { }

	public void set_mipMapBias(float value) { }

	public override void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_wrapModeU(TextureWrapMode value) { }

	public void set_wrapModeV(TextureWrapMode value) { }

	public void set_wrapModeW(TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

}


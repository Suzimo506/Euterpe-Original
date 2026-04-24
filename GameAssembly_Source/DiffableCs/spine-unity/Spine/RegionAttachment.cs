namespace Spine;

public class RegionAttachment : Attachment, IHasRendererObject
{
	public const int BLX = 0; //Field offset: 0x0
	public const int BLY = 1; //Field offset: 0x0
	public const int ULX = 2; //Field offset: 0x0
	public const int ULY = 3; //Field offset: 0x0
	public const int URX = 4; //Field offset: 0x0
	public const int URY = 5; //Field offset: 0x0
	public const int BRX = 6; //Field offset: 0x0
	public const int BRY = 7; //Field offset: 0x0
	internal float x; //Field offset: 0x18
	internal float y; //Field offset: 0x1C
	internal float rotation; //Field offset: 0x20
	internal float scaleX; //Field offset: 0x24
	internal float scaleY; //Field offset: 0x28
	internal float width; //Field offset: 0x2C
	internal float height; //Field offset: 0x30
	internal float regionOffsetX; //Field offset: 0x34
	internal float regionOffsetY; //Field offset: 0x38
	internal float regionWidth; //Field offset: 0x3C
	internal float regionHeight; //Field offset: 0x40
	internal float regionOriginalWidth; //Field offset: 0x44
	internal float regionOriginalHeight; //Field offset: 0x48
	internal Single[] offset; //Field offset: 0x50
	internal Single[] uvs; //Field offset: 0x58
	internal float r; //Field offset: 0x60
	internal float g; //Field offset: 0x64
	internal float b; //Field offset: 0x68
	internal float a; //Field offset: 0x6C
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private object <RendererObject>k__BackingField; //Field offset: 0x78

	public float A
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float B
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float G
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Single[] Offset
	{
		 get { } //Length: 5
	}

	public string Path
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public float R
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionHeight
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionOffsetX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionOffsetY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionOriginalHeight
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionOriginalWidth
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RegionWidth
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override object RendererObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public float Rotation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ScaleX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ScaleY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Single[] UVs
	{
		 get { } //Length: 5
	}

	public float Width
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float X
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Y
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public RegionAttachment(string name) { }

	public void ComputeWorldVertices(Bone bone, Single[] worldVertices, int offset, int stride = 2) { }

	public virtual Attachment Copy() { }

	public float get_A() { }

	public float get_B() { }

	public float get_G() { }

	public float get_Height() { }

	public Single[] get_Offset() { }

	[CompilerGenerated]
	public string get_Path() { }

	public float get_R() { }

	public float get_RegionHeight() { }

	public float get_RegionOffsetX() { }

	public float get_RegionOffsetY() { }

	public float get_RegionOriginalHeight() { }

	public float get_RegionOriginalWidth() { }

	public float get_RegionWidth() { }

	[CompilerGenerated]
	public override object get_RendererObject() { }

	public float get_Rotation() { }

	public float get_ScaleX() { }

	public float get_ScaleY() { }

	public Single[] get_UVs() { }

	public float get_Width() { }

	public float get_X() { }

	public float get_Y() { }

	public void set_A(float value) { }

	public void set_B(float value) { }

	public void set_G(float value) { }

	public void set_Height(float value) { }

	[CompilerGenerated]
	public void set_Path(string value) { }

	public void set_R(float value) { }

	public void set_RegionHeight(float value) { }

	public void set_RegionOffsetX(float value) { }

	public void set_RegionOffsetY(float value) { }

	public void set_RegionOriginalHeight(float value) { }

	public void set_RegionOriginalWidth(float value) { }

	public void set_RegionWidth(float value) { }

	[CompilerGenerated]
	public override void set_RendererObject(object value) { }

	public void set_Rotation(float value) { }

	public void set_ScaleX(float value) { }

	public void set_ScaleY(float value) { }

	public void set_Width(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void SetUVs(float u, float v, float u2, float v2, bool rotate) { }

	public void UpdateOffset() { }

}


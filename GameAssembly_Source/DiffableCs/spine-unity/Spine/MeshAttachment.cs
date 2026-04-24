namespace Spine;

public class MeshAttachment : VertexAttachment, IHasRendererObject
{
	internal float regionOffsetX; //Field offset: 0x40
	internal float regionOffsetY; //Field offset: 0x44
	internal float regionWidth; //Field offset: 0x48
	internal float regionHeight; //Field offset: 0x4C
	internal float regionOriginalWidth; //Field offset: 0x50
	internal float regionOriginalHeight; //Field offset: 0x54
	private MeshAttachment parentMesh; //Field offset: 0x58
	internal Single[] uvs; //Field offset: 0x60
	internal Single[] regionUVs; //Field offset: 0x68
	internal Int32[] triangles; //Field offset: 0x70
	internal float r; //Field offset: 0x78
	internal float g; //Field offset: 0x7C
	internal float b; //Field offset: 0x80
	internal float a; //Field offset: 0x84
	internal int hulllength; //Field offset: 0x88
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private object <RendererObject>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private float <RegionU>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <RegionV>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private float <RegionU2>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <RegionV2>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <RegionRotate>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private int <RegionDegrees>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private Int32[] <Edges>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <Width>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private float <Height>k__BackingField; //Field offset: 0xC4

	public float A
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float B
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public Int32[] Edges
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public float G
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Height
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public int HullLength
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public MeshAttachment ParentMesh
	{
		 get { } //Length: 5
		 set { } //Length: 177
	}

	public string Path
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public float R
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public int RegionDegrees
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
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

	public bool RegionRotate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float RegionU
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float RegionU2
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Single[] RegionUVs
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float RegionV
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float RegionV2
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float RegionWidth
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override object RendererObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Int32[] Triangles
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Single[] UVs
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float Width
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public MeshAttachment(string name) { }

	public virtual Attachment Copy() { }

	public float get_A() { }

	public float get_B() { }

	[CompilerGenerated]
	public Int32[] get_Edges() { }

	public float get_G() { }

	[CompilerGenerated]
	public float get_Height() { }

	public int get_HullLength() { }

	public MeshAttachment get_ParentMesh() { }

	[CompilerGenerated]
	public string get_Path() { }

	public float get_R() { }

	[CompilerGenerated]
	public int get_RegionDegrees() { }

	public float get_RegionHeight() { }

	public float get_RegionOffsetX() { }

	public float get_RegionOffsetY() { }

	public float get_RegionOriginalHeight() { }

	public float get_RegionOriginalWidth() { }

	[CompilerGenerated]
	public bool get_RegionRotate() { }

	[CompilerGenerated]
	public float get_RegionU() { }

	[CompilerGenerated]
	public float get_RegionU2() { }

	public Single[] get_RegionUVs() { }

	[CompilerGenerated]
	public float get_RegionV() { }

	[CompilerGenerated]
	public float get_RegionV2() { }

	public float get_RegionWidth() { }

	[CompilerGenerated]
	public override object get_RendererObject() { }

	public Int32[] get_Triangles() { }

	public Single[] get_UVs() { }

	[CompilerGenerated]
	public float get_Width() { }

	public MeshAttachment NewLinkedMesh() { }

	public void set_A(float value) { }

	public void set_B(float value) { }

	[CompilerGenerated]
	public void set_Edges(Int32[] value) { }

	public void set_G(float value) { }

	[CompilerGenerated]
	public void set_Height(float value) { }

	public void set_HullLength(int value) { }

	public void set_ParentMesh(MeshAttachment value) { }

	[CompilerGenerated]
	public void set_Path(string value) { }

	public void set_R(float value) { }

	[CompilerGenerated]
	public void set_RegionDegrees(int value) { }

	public void set_RegionHeight(float value) { }

	public void set_RegionOffsetX(float value) { }

	public void set_RegionOffsetY(float value) { }

	public void set_RegionOriginalHeight(float value) { }

	public void set_RegionOriginalWidth(float value) { }

	[CompilerGenerated]
	public void set_RegionRotate(bool value) { }

	[CompilerGenerated]
	public void set_RegionU(float value) { }

	[CompilerGenerated]
	public void set_RegionU2(float value) { }

	public void set_RegionUVs(Single[] value) { }

	[CompilerGenerated]
	public void set_RegionV(float value) { }

	[CompilerGenerated]
	public void set_RegionV2(float value) { }

	public void set_RegionWidth(float value) { }

	[CompilerGenerated]
	public override void set_RendererObject(object value) { }

	public void set_Triangles(Int32[] value) { }

	public void set_UVs(Single[] value) { }

	[CompilerGenerated]
	public void set_Width(float value) { }

	public void UpdateUVs() { }

}


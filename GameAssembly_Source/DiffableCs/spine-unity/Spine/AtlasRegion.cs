namespace Spine;

public class AtlasRegion
{
	public AtlasPage page; //Field offset: 0x10
	public string name; //Field offset: 0x18
	public int x; //Field offset: 0x20
	public int y; //Field offset: 0x24
	public int width; //Field offset: 0x28
	public int height; //Field offset: 0x2C
	public float u; //Field offset: 0x30
	public float v; //Field offset: 0x34
	public float u2; //Field offset: 0x38
	public float v2; //Field offset: 0x3C
	public float offsetX; //Field offset: 0x40
	public float offsetY; //Field offset: 0x44
	public int originalWidth; //Field offset: 0x48
	public int originalHeight; //Field offset: 0x4C
	public int index; //Field offset: 0x50
	public bool rotate; //Field offset: 0x54
	public int degrees; //Field offset: 0x58
	public Int32[] splits; //Field offset: 0x60
	public Int32[] pads; //Field offset: 0x68

	public AtlasRegion() { }

	public AtlasRegion Clone() { }

}


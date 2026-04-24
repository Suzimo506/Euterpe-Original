namespace Spine;

public class AtlasPage
{
	public string name; //Field offset: 0x10
	public Format format; //Field offset: 0x18
	public TextureFilter minFilter; //Field offset: 0x1C
	public TextureFilter magFilter; //Field offset: 0x20
	public TextureWrap uWrap; //Field offset: 0x24
	public TextureWrap vWrap; //Field offset: 0x28
	public object rendererObject; //Field offset: 0x30
	public int width; //Field offset: 0x38
	public int height; //Field offset: 0x3C

	public AtlasPage() { }

	public AtlasPage Clone() { }

}


namespace Assets.Scripts.ReplaceTools;

public class ReplaceRawImage : AbstractReplace
{
	internal class ReplaceRawImagePart
	{
		public Texture newTexture; //Field offset: 0x10
		public bool replaceColor; //Field offset: 0x18
		public Color newColor; //Field offset: 0x1C

		public ReplaceRawImagePart() { }

		public void Replace(RawImage image) { }

	}

	public RawImage image; //Field offset: 0x10
	public List<ReplaceRawImagePart> parts; //Field offset: 0x18

	public ReplaceRawImage() { }

	public virtual void Replace(int index) { }

}


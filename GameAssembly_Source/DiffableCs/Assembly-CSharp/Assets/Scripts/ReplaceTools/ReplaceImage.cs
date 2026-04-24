namespace Assets.Scripts.ReplaceTools;

public class ReplaceImage : AbstractReplace
{
	internal class ReplaceRawImagePart
	{
		public Sprite newSprite; //Field offset: 0x10
		public bool replaceColor; //Field offset: 0x18
		public Color newColor; //Field offset: 0x1C

		public ReplaceRawImagePart() { }

		public void Replace(Image image) { }

	}

	public Image image; //Field offset: 0x10
	public List<ReplaceRawImagePart> parts; //Field offset: 0x18

	public ReplaceImage() { }

	public virtual void Replace(int index) { }

}


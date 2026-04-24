namespace Assets.Scripts.ReplaceTools;

public class ReplaceSprite : AbstractReplace
{
	internal class ReplaceSpritePart
	{
		public Sprite newSprite; //Field offset: 0x10
		public bool replaceColor; //Field offset: 0x18
		public Color newColor; //Field offset: 0x1C

		public ReplaceSpritePart() { }

		public void Replace(SpriteRenderer sprite) { }

	}

	public SpriteRenderer sprite; //Field offset: 0x10
	public List<ReplaceSpritePart> parts; //Field offset: 0x18

	public ReplaceSprite() { }

	public virtual void Replace(int index) { }

}


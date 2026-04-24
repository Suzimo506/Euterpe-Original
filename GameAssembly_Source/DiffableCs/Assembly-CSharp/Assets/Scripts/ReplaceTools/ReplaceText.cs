namespace Assets.Scripts.ReplaceTools;

public class ReplaceText : AbstractReplace
{
	internal class ReplaceTextPart
	{
		public Color newColor; //Field offset: 0x10
		public bool replaceOutline; //Field offset: 0x20
		public Color outlineColor; //Field offset: 0x24

		public ReplaceTextPart() { }

		public void Replace(Text text) { }

	}

	public Text text; //Field offset: 0x10
	public List<ReplaceTextPart> parts; //Field offset: 0x18

	public ReplaceText() { }

	public virtual void Replace(int index) { }

}


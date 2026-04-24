namespace Assets.Scripts.ReplaceTools;

public class ReplaceMeshProText : AbstractReplace
{
	internal class ReplaceMeshProPart
	{
		public bool replaceColor; //Field offset: 0x10
		public Color newColor; //Field offset: 0x14
		public Color outlineColor; //Field offset: 0x24

		public ReplaceMeshProPart() { }

		public void Replace(TextMeshPro textMeshPro) { }

	}

	public TextMeshPro meshPro; //Field offset: 0x10
	public List<ReplaceMeshProPart> parts; //Field offset: 0x18

	public ReplaceMeshProText() { }

	public virtual void Replace(int index) { }

}


namespace Assets.Scripts.ReplaceTools;

public class ReplaceFlowTexture : AbstractReplace
{
	internal class ReplaceFlowTexturePart
	{
		public Texture newTexture; //Field offset: 0x10
		public bool replaceColor; //Field offset: 0x18
		public Color newColor; //Field offset: 0x1C

		public ReplaceFlowTexturePart() { }

		public void Replace(FlowTexture flowTexture) { }

	}

	public FlowTexture flowTexture; //Field offset: 0x10
	public List<ReplaceFlowTexturePart> parts; //Field offset: 0x18

	public ReplaceFlowTexture() { }

	public virtual void Replace(int index) { }

}


namespace Assets.Scripts.ReplaceTools;

public class ReplaceDoTween : AbstractReplace
{
	internal class ReplaceDoTweenPart
	{
		public bool replaceColor; //Field offset: 0x10
		public Color newToColor; //Field offset: 0x14

		public ReplaceDoTweenPart() { }

		public void Replace(DOTweenAnimation doTween) { }

	}

	public DOTweenAnimation doTweenAnimation; //Field offset: 0x10
	public List<ReplaceDoTweenPart> parts; //Field offset: 0x18

	public ReplaceDoTween() { }

	public virtual void Replace(int index) { }

}


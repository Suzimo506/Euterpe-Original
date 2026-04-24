namespace Assets.Scripts.ReplaceTools;

public class ReplaceEffectSliderLight : AbstractReplace
{
	internal class ReplaceEffectLightPart
	{
		public bool replaceColor; //Field offset: 0x10
		public Color newFromColor; //Field offset: 0x14
		public Color newToColor; //Field offset: 0x24

		public ReplaceEffectLightPart() { }

		public void Replace(EffectSliderLight effectSliderLight) { }

	}

	public EffectSliderLight effectSliderLight; //Field offset: 0x10
	public List<ReplaceEffectLightPart> parts; //Field offset: 0x18

	public ReplaceEffectSliderLight() { }

	public virtual void Replace(int index) { }

}


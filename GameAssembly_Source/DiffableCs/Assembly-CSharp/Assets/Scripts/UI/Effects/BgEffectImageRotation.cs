namespace Assets.Scripts.UI.Effects;

public class BgEffectImageRotation : BgEffect
{
	public FancyScrollView fancyScrollView; //Field offset: 0x30
	public float staticRotateSpeed; //Field offset: 0x38
	public float speedFactor; //Field offset: 0x3C
	private float m_Direction; //Field offset: 0x40

	public BgEffectImageRotation() { }

	private void Update() { }

}


namespace Assets.Scripts.ReplaceTools;

public class ReplaceParticle : AbstractReplace
{
	internal class ReplaceParticlePart
	{
		public ParticleSystemGradientMode mode; //Field offset: 0x10
		public bool replaceColor; //Field offset: 0x14
		public bool replaceColorLife; //Field offset: 0x15
		public Gradient newGradient; //Field offset: 0x18
		public Color newColor; //Field offset: 0x20

		public ReplaceParticlePart() { }

		public void Replace(ParticleSystem particleSystem) { }

	}

	public ParticleSystem particleSystem; //Field offset: 0x10
	public List<ReplaceParticlePart> parts; //Field offset: 0x18

	public ReplaceParticle() { }

	public virtual void Replace(int index) { }

}


namespace Assets.Scripts.ReplaceTools;

public class ReplaceSpine : AbstractReplace
{
	internal class ReplaceSpinePart
	{
		public SkeletonDataAsset spineAsset; //Field offset: 0x10
		public RuntimeAnimatorController animatorController; //Field offset: 0x18

		public ReplaceSpinePart() { }

		public void Replace(SkeletonMecanim mecanim, Animator animator) { }

		public void Replace(SkeletonAnimation animation) { }

	}

	public SpineType spineType; //Field offset: 0x10
	public SkeletonAnimation skeleton; //Field offset: 0x18
	public Animator animator; //Field offset: 0x20
	public SkeletonMecanim skeletonMecanim; //Field offset: 0x28
	public List<ReplaceSpinePart> parts; //Field offset: 0x30

	public ReplaceSpine() { }

	public virtual void Replace(int index) { }

}


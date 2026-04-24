namespace Spine.Unity;

[CreateAssetMenu]
public class AnimationReferenceAsset : ScriptableObject, IHasSkeletonDataAsset
{
	private const bool QuietSkeletonData = True; //Field offset: 0x0
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; //Field offset: 0x18
	[SerializeField]
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected string animationName; //Field offset: 0x20
	private Animation animation; //Field offset: 0x28

	public Animation Animation
	{
		 get { } //Length: 35
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		 get { } //Length: 5
	}

	public AnimationReferenceAsset() { }

	public Animation get_Animation() { }

	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	public void Initialize() { }

	public static Animation op_Implicit(AnimationReferenceAsset asset) { }

}


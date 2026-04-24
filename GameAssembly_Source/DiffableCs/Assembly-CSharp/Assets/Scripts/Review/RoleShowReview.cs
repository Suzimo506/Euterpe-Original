namespace Assets.Scripts.Review;

public class RoleShowReview : MonoBehaviour
{
	public RoleShowType roleShowType; //Field offset: 0x18
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	public RuntimeAnimatorController reviewController; //Field offset: 0x30
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x38
	public string startingAnimation; //Field offset: 0x40
	public SkeletonDataAsset reviewDataAsset; //Field offset: 0x48

	public RoleShowReview() { }

	private void ReviewReplace() { }

	private void Start() { }

}


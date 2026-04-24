namespace Spine.Unity;

public abstract class SkeletonRootMotionBase : MonoBehaviour
{
	[SerializeField]
	[SpineBone(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected string rootMotionBoneName; //Field offset: 0x18
	public bool transformPositionX; //Field offset: 0x20
	public bool transformPositionY; //Field offset: 0x21
	public float rootMotionScaleX; //Field offset: 0x24
	public float rootMotionScaleY; //Field offset: 0x28
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Rigidbody2D rigidBody2D; //Field offset: 0x30
	public Rigidbody rigidBody; //Field offset: 0x38
	protected ISkeletonComponent skeletonComponent; //Field offset: 0x40
	protected Bone rootMotionBone; //Field offset: 0x48
	protected int rootMotionBoneIndex; //Field offset: 0x50
	protected List<Bone> topLevelBones; //Field offset: 0x58
	protected Vector2 rigidbodyDisplacement; //Field offset: 0x60

	protected override float AdditionalScale
	{
		 get { } //Length: 9
	}

	public bool UsesRigidbody
	{
		 get { } //Length: 161
	}

	protected SkeletonRootMotionBase() { }

	private void AdjustMovementDeltaToConfiguration(ref Vector2 localDelta, Skeleton skeleton) { }

	public void AdjustRootMotionToDistance(Vector2 distanceToTarget, int trackIndex = 0) { }

	private void ApplyRootMotion(Vector2 localDelta) { }

	protected abstract Vector2 CalculateAnimationsMovementDelta() { }

	protected void FindRigidbodyComponent() { }

	protected override void FixedUpdate() { }

	private void GatherTopLevelBones() { }

	protected override float get_AdditionalScale() { }

	public bool get_UsesRigidbody() { }

	public Vector2 GetAnimationRootMotion(Animation animation) { }

	public Vector2 GetAnimationRootMotion(float startTime, float endTime, Animation animation) { }

	public abstract Vector2 GetRemainingRootMotion(int trackIndex = 0) { }

	private Vector2 GetTimelineMovementDelta(float startTime, float endTime, TranslateTimeline timeline, Animation animation) { }

	private void HandleUpdateLocal(ISkeletonAnimation animatedSkeletonComponent) { }

	protected override void OnDisable() { }

	protected override void Reset() { }

	public void SetRootMotionBone(string name) { }

	protected override void Start() { }

}


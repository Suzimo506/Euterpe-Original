namespace Spine.Unity;

[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonRootMotion : SkeletonRootMotionBase
{
	private const int DefaultAnimationTrackFlags = -1; //Field offset: 0x0
	public int animationTrackFlags; //Field offset: 0x68
	private AnimationState animationState; //Field offset: 0x70
	private Canvas canvas; //Field offset: 0x78

	protected virtual float AdditionalScale
	{
		 get { } //Length: 138
	}

	public SkeletonRootMotion() { }

	private void ApplyMixAlphaToDelta(ref Vector2 currentDelta, TrackEntry next, TrackEntry track) { }

	protected virtual Vector2 CalculateAnimationsMovementDelta() { }

	protected virtual float get_AdditionalScale() { }

	public virtual Vector2 GetRemainingRootMotion(int trackIndex) { }

	protected virtual void Reset() { }

	protected virtual void Start() { }

}


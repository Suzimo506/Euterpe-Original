namespace Spine.Unity;

[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonMecanimRootMotion : SkeletonRootMotionBase
{
	private const int DefaultMecanimLayerFlags = -1; //Field offset: 0x0
	public int mecanimLayerFlags; //Field offset: 0x68
	protected Vector2 movementDelta; //Field offset: 0x6C
	private SkeletonMecanim skeletonMecanim; //Field offset: 0x78

	public SkeletonMecanim SkeletonMecanim
	{
		 get { } //Length: 166
	}

	public SkeletonMecanimRootMotion() { }

	protected virtual Vector2 CalculateAnimationsMovementDelta() { }

	public SkeletonMecanim get_SkeletonMecanim() { }

	public virtual Vector2 GetRemainingRootMotion(int layerIndex) { }

	private void OnClipApplied(Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

	protected virtual void Reset() { }

	protected virtual void Start() { }

}


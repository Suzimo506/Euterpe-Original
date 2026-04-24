namespace Spine.Unity;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class SkeletonUtilityConstraint : MonoBehaviour
{
	protected SkeletonUtilityBone bone; //Field offset: 0x18
	protected SkeletonUtility hierarchy; //Field offset: 0x20

	protected SkeletonUtilityConstraint() { }

	public abstract void DoUpdate() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

}


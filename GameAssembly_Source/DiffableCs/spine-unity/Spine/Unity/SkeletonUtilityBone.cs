namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonUtilityBone : MonoBehaviour
{
	internal enum Mode
	{
		Follow = 0,
		Override = 1,
	}

	internal enum UpdatePhase
	{
		Local = 0,
		World = 1,
		Complete = 2,
	}

	public string boneName; //Field offset: 0x18
	public Transform parentReference; //Field offset: 0x20
	public Mode mode; //Field offset: 0x28
	public bool position; //Field offset: 0x2C
	public bool rotation; //Field offset: 0x2D
	public bool scale; //Field offset: 0x2E
	public bool zPosition; //Field offset: 0x2F
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float overrideAlpha; //Field offset: 0x30
	public SkeletonUtility hierarchy; //Field offset: 0x38
	public Bone bone; //Field offset: 0x40
	public bool transformLerpComplete; //Field offset: 0x48
	public bool valid; //Field offset: 0x49
	private Transform cachedTransform; //Field offset: 0x50
	private Transform skeletonTransform; //Field offset: 0x58
	private bool incompatibleTransformMode; //Field offset: 0x60

	public bool IncompatibleTransformMode
	{
		 get { } //Length: 5
	}

	public SkeletonUtilityBone() { }

	public void AddBoundingBox(string skinName, string slotName, string attachmentName) { }

	public static bool BoneTransformModeIncompatible(Bone bone) { }

	public void DoUpdate(UpdatePhase phase) { }

	public bool get_IncompatibleTransformMode() { }

	private void HandleOnReset() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Reset() { }

}


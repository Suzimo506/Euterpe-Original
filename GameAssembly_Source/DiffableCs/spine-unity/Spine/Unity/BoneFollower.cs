namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BoneFollower : MonoBehaviour
{
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x18
	[SpineBone(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string boneName; //Field offset: 0x20
	public bool followXYPosition; //Field offset: 0x28
	public bool followZPosition; //Field offset: 0x29
	public bool followBoneRotation; //Field offset: 0x2A
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool followSkeletonFlip; //Field offset: 0x2B
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool followLocalScale; //Field offset: 0x2C
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool initializeOnAwake; //Field offset: 0x2D
	public bool valid; //Field offset: 0x2E
	public Bone bone; //Field offset: 0x30
	private Transform skeletonTransform; //Field offset: 0x38
	private bool skeletonTransformIsParent; //Field offset: 0x40

	public SkeletonRenderer SkeletonRenderer
	{
		 get { } //Length: 5
		 set { } //Length: 37
	}

	public BoneFollower() { }

	public void Awake() { }

	public SkeletonRenderer get_SkeletonRenderer() { }

	public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	public void Initialize() { }

	public void LateUpdate() { }

	private void OnDestroy() { }

	public void set_SkeletonRenderer(SkeletonRenderer value) { }

	public bool SetBone(string name) { }

}


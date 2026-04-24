namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BoneFollowerGraphic : MonoBehaviour
{
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x18
	public bool initializeOnAwake; //Field offset: 0x20
	[SpineBone(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string boneName; //Field offset: 0x28
	public bool followBoneRotation; //Field offset: 0x30
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool followSkeletonFlip; //Field offset: 0x31
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool followLocalScale; //Field offset: 0x32
	public bool followXYPosition; //Field offset: 0x33
	public bool followZPosition; //Field offset: 0x34
	public Bone bone; //Field offset: 0x38
	private Transform skeletonTransform; //Field offset: 0x40
	private bool skeletonTransformIsParent; //Field offset: 0x48
	public bool valid; //Field offset: 0x49

	public SkeletonGraphic SkeletonGraphic
	{
		 get { } //Length: 5
		 set { } //Length: 37
	}

	public BoneFollowerGraphic() { }

	public void Awake() { }

	public SkeletonGraphic get_SkeletonGraphic() { }

	public void Initialize() { }

	public void LateUpdate() { }

	public void set_SkeletonGraphic(SkeletonGraphic value) { }

	public bool SetBone(string name) { }

}


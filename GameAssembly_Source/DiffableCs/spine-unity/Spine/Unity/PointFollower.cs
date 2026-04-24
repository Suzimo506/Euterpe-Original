namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, IHasSkeletonComponent
{
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x18
	[SpineSlot(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string slotName; //Field offset: 0x20
	[SpineAttachment(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string pointAttachmentName; //Field offset: 0x28
	public bool followRotation; //Field offset: 0x30
	public bool followSkeletonFlip; //Field offset: 0x31
	public bool followSkeletonZPosition; //Field offset: 0x32
	private Transform skeletonTransform; //Field offset: 0x38
	private bool skeletonTransformIsParent; //Field offset: 0x40
	private PointAttachment point; //Field offset: 0x48
	private Bone bone; //Field offset: 0x50
	private bool valid; //Field offset: 0x58

	public bool IsValid
	{
		 get { } //Length: 5
	}

	public override ISkeletonComponent SkeletonComponent
	{
		 get { } //Length: 5
	}

	public override SkeletonRenderer SkeletonRenderer
	{
		 get { } //Length: 5
	}

	public PointFollower() { }

	public bool get_IsValid() { }

	public override ISkeletonComponent get_SkeletonComponent() { }

	public override SkeletonRenderer get_SkeletonRenderer() { }

	private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	public void Initialize() { }

	public void LateUpdate() { }

	private void OnDestroy() { }

	private void UpdateReferences() { }

}


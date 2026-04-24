namespace Spine.Unity;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SkeletonUtility : MonoBehaviour
{
	internal sealed class SkeletonUtilityDelegate : MulticastDelegate
	{

		public SkeletonUtilityDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private SkeletonUtilityDelegate OnReset; //Field offset: 0x18
	public Transform boneRoot; //Field offset: 0x20
	public bool flipBy180DegreeRotation; //Field offset: 0x28
	[HideInInspector]
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x30
	[HideInInspector]
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x38
	private Canvas canvas; //Field offset: 0x40
	public ISkeletonAnimation skeletonAnimation; //Field offset: 0x48
	private ISkeletonComponent skeletonComponent; //Field offset: 0x50
	public List<SkeletonUtilityBone> boneComponents; //Field offset: 0x58
	public List<SkeletonUtilityConstraint> constraintComponents; //Field offset: 0x60
	private float positionScale; //Field offset: 0x68
	private bool hasOverrideBones; //Field offset: 0x6C
	private bool hasConstraints; //Field offset: 0x6D
	private bool needToReprocessBones; //Field offset: 0x6E

	public event SkeletonUtilityDelegate OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool IsValid
	{
		 get { } //Length: 220
	}

	public float PositionScale
	{
		 get { } //Length: 6
	}

	public Skeleton Skeleton
	{
		 get { } //Length: 300
	}

	public ISkeletonComponent SkeletonComponent
	{
		 get { } //Length: 240
	}

	public SkeletonUtility() { }

	[CompilerGenerated]
	public void add_OnReset(SkeletonUtilityDelegate value) { }

	public static Rigidbody2D AddBoneRigidbody2D(GameObject gameObject, bool isKinematic = true, float gravityScale = 0) { }

	public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment box, Slot slot, GameObject gameObject, bool isTrigger = true) { }

	public static PolygonCollider2D AddBoundingBoxGameObject(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = true) { }

	public static PolygonCollider2D AddBoundingBoxGameObject(string name, BoundingBoxAttachment box, Slot slot, Transform parent, bool isTrigger = true) { }

	public void CollectBones() { }

	public bool get_IsValid() { }

	public float get_PositionScale() { }

	public Skeleton get_Skeleton() { }

	public ISkeletonComponent get_SkeletonComponent() { }

	public Transform GetBoneRoot() { }

	public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0) { }

	private void HandleRendererReset(SkeletonGraphic g) { }

	private void HandleRendererReset(SkeletonRenderer r) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RegisterBone(SkeletonUtilityBone bone) { }

	public void RegisterConstraint(SkeletonUtilityConstraint constraint) { }

	[CompilerGenerated]
	public void remove_OnReset(SkeletonUtilityDelegate value) { }

	public void ResubscribeEvents() { }

	public static void SetColliderPointsLocal(PolygonCollider2D collider, Slot slot, BoundingBoxAttachment box, float scale = 1) { }

	public GameObject SpawnBone(Bone bone, Transform parent, Mode mode, bool pos, bool rot, bool sca) { }

	public GameObject SpawnBoneRecursively(Bone bone, Transform parent, Mode mode, bool pos, bool rot, bool sca) { }

	public GameObject SpawnHierarchy(Mode mode, bool pos, bool rot, bool sca) { }

	public GameObject SpawnRoot(Mode mode, bool pos, bool rot, bool sca) { }

	private void Start() { }

	public void UnregisterBone(SkeletonUtilityBone bone) { }

	public void UnregisterConstraint(SkeletonUtilityConstraint constraint) { }

	private void Update() { }

	private void UpdateAllBones(UpdatePhase phase) { }

	private void UpdateComplete(ISkeletonAnimation anim) { }

	private void UpdateLocal(ISkeletonAnimation anim) { }

	private void UpdateWorld(ISkeletonAnimation anim) { }

}


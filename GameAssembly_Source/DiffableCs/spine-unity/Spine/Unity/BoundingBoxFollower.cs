namespace Spine.Unity;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class BoundingBoxFollower : MonoBehaviour
{
	internal static bool DebugMessages; //Field offset: 0x0
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x18
	[SpineSlot(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string slotName; //Field offset: 0x20
	public bool isTrigger; //Field offset: 0x28
	public bool clearStateOnDisable; //Field offset: 0x29
	private Slot slot; //Field offset: 0x30
	private BoundingBoxAttachment currentAttachment; //Field offset: 0x38
	private string currentAttachmentName; //Field offset: 0x40
	private PolygonCollider2D currentCollider; //Field offset: 0x48
	public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable; //Field offset: 0x50
	public readonly Dictionary<BoundingBoxAttachment, String> nameTable; //Field offset: 0x58

	public BoundingBoxAttachment CurrentAttachment
	{
		 get { } //Length: 5
	}

	public string CurrentAttachmentName
	{
		 get { } //Length: 5
	}

	public PolygonCollider2D CurrentCollider
	{
		 get { } //Length: 5
	}

	public bool IsTrigger
	{
		 get { } //Length: 5
	}

	public Slot Slot
	{
		 get { } //Length: 5
	}

	private static BoundingBoxFollower() { }

	public BoundingBoxFollower() { }

	private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, ref int collidersCount) { }

	public void ClearState() { }

	private void DisposeExcessCollidersAfter(int requiredCount) { }

	public BoundingBoxAttachment get_CurrentAttachment() { }

	public string get_CurrentAttachmentName() { }

	public PolygonCollider2D get_CurrentCollider() { }

	public bool get_IsTrigger() { }

	public Slot get_Slot() { }

	private void HandleRebuild(SkeletonRenderer sr) { }

	public void Initialize(bool overwrite = false) { }

	private void LateUpdate() { }

	private void MatchAttachment(Attachment attachment) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

}


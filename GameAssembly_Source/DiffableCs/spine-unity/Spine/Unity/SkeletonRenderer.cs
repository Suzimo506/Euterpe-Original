namespace Spine.Unity;

[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, IHasSkeletonDataAsset
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public string startsWith; //Field offset: 0x10

		public <>c__DisplayClass75_0() { }

		internal bool <FindAndApplySeparatorSlots>b__0(string slotName) { }

	}

	internal sealed class InstructionDelegate : MulticastDelegate
	{

		public InstructionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SkeletonRendererInstruction instruction, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SkeletonRendererInstruction instruction) { }

	}

	internal sealed class SkeletonRendererDelegate : MulticastDelegate
	{

		public SkeletonRendererDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SkeletonRenderer skeletonRenderer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SkeletonRenderer skeletonRenderer) { }

	}

	internal class SpriteMaskInteractionMaterials
	{
		public Material[] materialsMaskDisabled; //Field offset: 0x10
		public Material[] materialsInsideMask; //Field offset: 0x18
		public Material[] materialsOutsideMask; //Field offset: 0x20

		public bool AnyMaterialCreated
		{
			 get { } //Length: 69
		}

		public SpriteMaskInteractionMaterials() { }

		public bool get_AnyMaterialCreated() { }

	}

	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = 5; //Field offset: 0x0
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = 4; //Field offset: 0x0
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = 8; //Field offset: 0x0
	public static readonly int STENCIL_COMP_PARAM_ID; //Field offset: 0x0
	public static readonly int SUBMESH_DUMMY_PARAM_ID; //Field offset: 0x4
	public SkeletonDataAsset skeletonDataAsset; //Field offset: 0x18
	[SpineSkin(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string initialSkinName; //Field offset: 0x20
	public bool initialFlipX; //Field offset: 0x28
	public bool initialFlipY; //Field offset: 0x29
	protected UpdateMode updateMode; //Field offset: 0x2C
	public UpdateMode updateWhenInvisible; //Field offset: 0x30
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[SpineSlot(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected String[] separatorSlotNames; //Field offset: 0x38
	public readonly List<Slot> separatorSlots; //Field offset: 0x40
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float zSpacing; //Field offset: 0x48
	public bool useClipping; //Field offset: 0x4C
	public bool immutableTriangles; //Field offset: 0x4D
	public bool pmaVertexColors; //Field offset: 0x4E
	public bool clearStateOnDisable; //Field offset: 0x4F
	public bool tintBlack; //Field offset: 0x50
	public bool singleSubmesh; //Field offset: 0x51
	public bool fixDrawOrder; //Field offset: 0x52
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool addNormals; //Field offset: 0x53
	public bool calculateTangents; //Field offset: 0x54
	public SpriteMaskInteraction maskInteraction; //Field offset: 0x58
	public SpriteMaskInteractionMaterials maskMaterials; //Field offset: 0x60
	public bool disableRenderingOnOverride; //Field offset: 0x68
	[CompilerGenerated]
	private InstructionDelegate generateMeshOverride; //Field offset: 0x70
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; //Field offset: 0x78
	private readonly Dictionary<Material, Material> customMaterialOverride; //Field offset: 0x80
	private readonly Dictionary<Slot, Material> customSlotMaterials; //Field offset: 0x88
	private readonly SkeletonRendererInstruction currentInstructions; //Field offset: 0x90
	private readonly MeshGenerator meshGenerator; //Field offset: 0x98
	private readonly MeshRendererBuffers rendererBuffers; //Field offset: 0xA0
	private MeshRenderer meshRenderer; //Field offset: 0xA8
	private MeshFilter meshFilter; //Field offset: 0xB0
	public bool valid; //Field offset: 0xB8
	public Skeleton skeleton; //Field offset: 0xC0
	[CompilerGenerated]
	private SkeletonRendererDelegate OnRebuild; //Field offset: 0xC8
	[CompilerGenerated]
	private SkeletonRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0xD0
	private MaterialPropertyBlock reusedPropertyBlock; //Field offset: 0xD8

	private event InstructionDelegate generateMeshOverride
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public event InstructionDelegate GenerateMeshOverride
	{
		 add { } //Length: 227
		 remove { } //Length: 227
	}

	public event SkeletonRendererDelegate OnMeshAndMaterialsUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event MeshGeneratorDelegate OnPostProcessVertices
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event SkeletonRendererDelegate OnRebuild
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Dictionary<Material, Material> CustomMaterialOverride
	{
		 get { } //Length: 8
	}

	public Dictionary<Slot, Material> CustomSlotMaterials
	{
		 get { } //Length: 8
	}

	public override Skeleton Skeleton
	{
		 get { } //Length: 40
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		 get { } //Length: 5
	}

	public UpdateMode UpdateMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static SkeletonRenderer() { }

	public SkeletonRenderer() { }

	[CompilerGenerated]
	private void add_generateMeshOverride(InstructionDelegate value) { }

	public void add_GenerateMeshOverride(InstructionDelegate value) { }

	[CompilerGenerated]
	public void add_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public void add_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	public void add_OnRebuild(SkeletonRendererDelegate value) { }

	public static T AddSpineComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset) { }

	private void AssignSpriteMaskMaterials() { }

	public override void Awake() { }

	public override void ClearState() { }

	public void EnsureMeshGeneratorCapacity(int minimumVertexCount) { }

	public void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators = true, bool updateStringArray = false) { }

	public void FindAndApplySeparatorSlots(Func<String, Boolean> slotNamePredicate, bool clearExistingSeparators = true, bool updateStringArray = false) { }

	public Dictionary<Material, Material> get_CustomMaterialOverride() { }

	public Dictionary<Slot, Material> get_CustomSlotMaterials() { }

	public override Skeleton get_Skeleton() { }

	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	public UpdateMode get_UpdateMode() { }

	public override void Initialize(bool overwrite) { }

	private bool InitSpriteMaskMaterialsForMaskType(CompareFunction maskFunction, ref Material[] materialsToFill) { }

	private bool InitSpriteMaskMaterialsInsideMask() { }

	private bool InitSpriteMaskMaterialsOutsideMask() { }

	public override void LateUpdate() { }

	public static T NewSpineGameObject(SkeletonDataAsset skeletonDataAsset) { }

	public void OnBecameInvisible() { }

	public void OnBecameVisible() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void ReapplySeparatorSlotNames() { }

	[CompilerGenerated]
	private void remove_generateMeshOverride(InstructionDelegate value) { }

	public void remove_GenerateMeshOverride(InstructionDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	public void remove_OnRebuild(SkeletonRendererDelegate value) { }

	public void set_UpdateMode(UpdateMode value) { }

	private void SetMaterialSettingsToFixDrawOrder() { }

	public void SetMeshSettings(Settings settings) { }

}


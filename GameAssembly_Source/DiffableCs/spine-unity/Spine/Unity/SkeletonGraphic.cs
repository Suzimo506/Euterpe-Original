namespace Spine.Unity;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset
{
	internal sealed class SkeletonRendererDelegate : MulticastDelegate
	{

		public SkeletonRendererDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SkeletonGraphic skeletonGraphic, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SkeletonGraphic skeletonGraphic) { }

	}

	public const string SeparatorPartGameObjectName = "Part"; //Field offset: 0x0
	public SkeletonDataAsset skeletonDataAsset; //Field offset: 0xC8
	[SpineSkin(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string initialSkinName; //Field offset: 0xD0
	public bool initialFlipX; //Field offset: 0xD8
	public bool initialFlipY; //Field offset: 0xD9
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string startingAnimation; //Field offset: 0xE0
	public bool startingLoop; //Field offset: 0xE8
	public float timeScale; //Field offset: 0xEC
	public bool freeze; //Field offset: 0xF0
	protected UpdateMode updateMode; //Field offset: 0xF4
	public UpdateMode updateWhenInvisible; //Field offset: 0xF8
	public bool unscaledTime; //Field offset: 0xFC
	public bool allowMultipleCanvasRenderers; //Field offset: 0xFD
	public List<CanvasRenderer> canvasRenderers; //Field offset: 0x100
	[SerializeField]
	[SpineSlot(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected String[] separatorSlotNames; //Field offset: 0x108
	public readonly List<Slot> separatorSlots; //Field offset: 0x110
	public bool enableSeparatorSlots; //Field offset: 0x118
	[SerializeField]
	protected List<Transform> separatorParts; //Field offset: 0x120
	public bool updateSeparatorPartLocation; //Field offset: 0x128
	private bool wasUpdatedAfterInit; //Field offset: 0x129
	private Texture baseTexture; //Field offset: 0x130
	private readonly Dictionary<Texture, Texture> customTextureOverride; //Field offset: 0x138
	private readonly Dictionary<Texture, Material> customMaterialOverride; //Field offset: 0x140
	private Texture overrideTexture; //Field offset: 0x148
	protected Skeleton skeleton; //Field offset: 0x150
	[CompilerGenerated]
	private SkeletonRendererDelegate OnRebuild; //Field offset: 0x158
	[CompilerGenerated]
	private SkeletonRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0x160
	protected AnimationState state; //Field offset: 0x168
	[SerializeField]
	protected MeshGenerator meshGenerator; //Field offset: 0x170
	private DoubleBuffered<SmartMesh> meshBuffers; //Field offset: 0x178
	private SkeletonRendererInstruction currentInstructions; //Field offset: 0x180
	private readonly ExposedList<Mesh> meshes; //Field offset: 0x188
	[CompilerGenerated]
	private UpdateBonesDelegate BeforeApply; //Field offset: 0x190
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateLocal; //Field offset: 0x198
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateWorld; //Field offset: 0x1A0
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateComplete; //Field offset: 0x1A8
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; //Field offset: 0x1B0

	public event UpdateBonesDelegate BeforeApply
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
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

	public override event UpdateBonesDelegate UpdateComplete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event UpdateBonesDelegate UpdateLocal
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event UpdateBonesDelegate UpdateWorld
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override AnimationState AnimationState
	{
		 get { } //Length: 8
	}

	public Dictionary<Texture, Material> CustomMaterialOverride
	{
		 get { } //Length: 8
	}

	public Dictionary<Texture, Texture> CustomTextureOverride
	{
		 get { } //Length: 8
	}

	public bool IsValid
	{
		 get { } //Length: 12
	}

	public virtual Texture mainTexture
	{
		 get { } //Length: 130
	}

	public MeshGenerator MeshGenerator
	{
		 get { } //Length: 8
	}

	public Texture OverrideTexture
	{
		 get { } //Length: 8
		 set { } //Length: 95
	}

	public List<Transform> SeparatorParts
	{
		 get { } //Length: 8
	}

	public override Skeleton Skeleton
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public SkeletonData SkeletonData
	{
		 get { } //Length: 18
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		 get { } //Length: 8
	}

	public UpdateMode UpdateMode
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public SkeletonGraphic() { }

	[CompilerGenerated]
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void add_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public void add_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	public void add_OnRebuild(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, Material material) { }

	protected void ApplyAnimation() { }

	protected virtual void Awake() { }

	public void Clear() { }

	protected void DisableUnusedCanvasRenderers(int usedCount) { }

	protected void EnsureCanvasRendererCount(int targetCount) { }

	protected void EnsureMeshesCount(int targetCount) { }

	protected void EnsureSeparatorPartCount() { }

	public override AnimationState get_AnimationState() { }

	public Dictionary<Texture, Material> get_CustomMaterialOverride() { }

	public Dictionary<Texture, Texture> get_CustomTextureOverride() { }

	public bool get_IsValid() { }

	public virtual Texture get_mainTexture() { }

	public MeshGenerator get_MeshGenerator() { }

	public Texture get_OverrideTexture() { }

	public List<Transform> get_SeparatorParts() { }

	public override Skeleton get_Skeleton() { }

	public SkeletonData get_SkeletonData() { }

	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	public UpdateMode get_UpdateMode() { }

	public Mesh GetLastMesh() { }

	public bool HasMultipleSubmeshInstructions() { }

	public void Initialize(bool overwrite) { }

	protected void InitMeshBuffers() { }

	public void LateUpdate() { }

	protected bool MatchRectTransformMultipleRenderers() { }

	protected bool MatchRectTransformSingleRenderer() { }

	public bool MatchRectTransformWithBounds() { }

	public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent, Material material) { }

	public void OnBecameInvisible() { }

	public void OnBecameVisible() { }

	protected virtual void OnDisable() { }

	public void ReapplySeparatorSlotNames() { }

	public virtual void Rebuild(CanvasUpdate update) { }

	[CompilerGenerated]
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public void remove_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	public void remove_OnRebuild(SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	public void set_OverrideTexture(Texture value) { }

	public void set_Skeleton(Skeleton value) { }

	public void set_UpdateMode(UpdateMode value) { }

	private void SetRectTransformBounds(Bounds combinedBounds) { }

	public void TrimRenderers() { }

	public override void Update() { }

	public override void Update(float deltaTime) { }

	protected void UpdateAnimationStatus(float deltaTime) { }

	public void UpdateMesh() { }

	protected void UpdateMeshMultipleCanvasRenderers(SkeletonRendererInstruction currentInstructions) { }

	protected void UpdateMeshSingleCanvasRenderer() { }

	protected void UpdateSeparatorPartParents() { }

}


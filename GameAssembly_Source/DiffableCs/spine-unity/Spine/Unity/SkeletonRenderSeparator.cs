namespace Spine.Unity;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class SkeletonRenderSeparator : MonoBehaviour
{
	public const int DefaultSortingOrderIncrement = 5; //Field offset: 0x0
	[SerializeField]
	protected SkeletonRenderer skeletonRenderer; //Field offset: 0x18
	private MeshRenderer mainMeshRenderer; //Field offset: 0x20
	public bool copyPropertyBlock; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool copyMeshRendererFlags; //Field offset: 0x29
	public List<SkeletonPartsRenderer> partsRenderers; //Field offset: 0x30
	[CompilerGenerated]
	private SkeletonRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0x38
	private MaterialPropertyBlock copiedBlock; //Field offset: 0x40

	public event SkeletonRendererDelegate OnMeshAndMaterialsUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public SkeletonRenderer SkeletonRenderer
	{
		 get { } //Length: 5
		 set { } //Length: 287
	}

	public SkeletonRenderSeparator() { }

	[CompilerGenerated]
	public void add_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	public SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement = 5, string name = null) { }

	public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = true) { }

	public SkeletonRenderer get_SkeletonRenderer() { }

	private void HandleRender(SkeletonRendererInstruction instruction) { }

	public void OnDisable() { }

	public void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	public void set_SkeletonRenderer(SkeletonRenderer value) { }

}


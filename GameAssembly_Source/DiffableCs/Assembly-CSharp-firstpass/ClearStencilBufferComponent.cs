//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ClearStencilBufferComponent : SkipMasking
{
	protected static ClearStencilBufferComponent _instance; //Field offset: 0x0
	public const string SHADER_MASK_CLEAR = "SpriteMask/ClearStencil"; //Field offset: 0x0
	[SerializeField]
	private Vector2 _size; //Field offset: 0x18
	[SerializeField]
	private Vector2 _pivot; //Field offset: 0x20
	private Vector3[] vertices; //Field offset: 0x28
	private MeshRenderer meshRenderer; //Field offset: 0x30
	private MeshFilter meshFilter; //Field offset: 0x38
	private int lastSortingOrder; //Field offset: 0x40
	private string lastSortingLayerName; //Field offset: 0x48

	public static ClearStencilBufferComponent Instance
	{
		 get { } //Length: 350
	}

	public Vector2 pivot
	{
		 get { } //Length: 19
		 set { } //Length: 11
	}

	public Vector2 size
	{
		 get { } //Length: 19
		 set { } //Length: 11
	}

	public ClearStencilBufferComponent() { }

	private void Awake() { }

	private static ClearStencilBufferComponent findInstance() { }

	public static ClearStencilBufferComponent get_Instance() { }

	public Vector2 get_pivot() { }

	public Vector2 get_size() { }

	public MeshRenderer getRenderer() { }

	protected override void OnDestroy() { }

	private void OnDrawGizmos() { }

	protected override void Reset() { }

	public void set_pivot(Vector2 value) { }

	public void set_size(Vector2 value) { }

	private void updateMeshSize() { }

}


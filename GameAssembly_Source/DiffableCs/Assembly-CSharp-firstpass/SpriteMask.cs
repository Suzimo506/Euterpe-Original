//Type is in global namespace

[ExecuteInEditMode]
public class SpriteMask : SpriteMaskingComponent
{
	internal enum Type
	{
		Rectangle = 0,
		Sprite = 1,
		Texture = 2,
		CustomMesh = 3,
		None = 100,
	}

	public const string SHADER_SPRITE_DEFAULT = "SpriteMask/Default"; //Field offset: 0x0
	public const string SHADER_SPRITE_DIFFUSE = "SpriteMask/Diffuse"; //Field offset: 0x0
	public const string SHADER_MASK_ROOT = "SpriteMask/Mask"; //Field offset: 0x0
	private const string STR_STENCIL = "_Stencil"; //Field offset: 0x0
	private const string STR_STENCIL_COMPARISON = "_StencilComp"; //Field offset: 0x0
	private const string STR_STENCIL_READ_MASK = "_StencilReadMask"; //Field offset: 0x0
	private const string STR_COLOR_MASK = "_ColorMask"; //Field offset: 0x0
	private const int MAX_LEVELS = 3; //Field offset: 0x0
	private const int BASE_RENDER_QUEUE = 3000; //Field offset: 0x0
	private static Boolean[] stencilIds; //Field offset: 0x0
	private static List<Renderer> rendererComponents; //Field offset: 0x8
	private static List<SpriteMask> maskComponents; //Field offset: 0x10
	private static List<SpriteMaskingComponent> maskingComponents; //Field offset: 0x18
	private static List<SpriteMaskingPart> maskingPartComponents; //Field offset: 0x20
	private static List<SkipMasking> skipMaskingComponents; //Field offset: 0x28
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	public List<Transform> maskedObjects; //Field offset: 0x20
	public bool forceDefaultMaterialOnChilds; //Field offset: 0x28
	public bool forceIndividualMaterialOnChilds; //Field offset: 0x29
	[SerializeField]
	private Type _type; //Field offset: 0x2C
	[SerializeField]
	private Vector2 _size; //Field offset: 0x30
	[SerializeField]
	private Vector2 _pivot; //Field offset: 0x38
	[SerializeField]
	private Texture2D _texture; //Field offset: 0x40
	[SerializeField]
	private Sprite _sprite; //Field offset: 0x48
	[SerializeField]
	private bool _inverted; //Field offset: 0x50
	[SerializeField]
	private bool _showMaskGraphics; //Field offset: 0x51
	private Dictionary<Material, Material> individualMaterials; //Field offset: 0x58
	private int propertyStencilReadMask; //Field offset: 0x60
	private int propertyStencilComp; //Field offset: 0x64
	private int propertyColorMask; //Field offset: 0x68
	private int propertyStencil; //Field offset: 0x6C
	private Vector3[] vertices; //Field offset: 0x70
	private Vector2[] uv; //Field offset: 0x78
	private Int32[] triangles; //Field offset: 0x80
	private Material _defaultSpriteMaterial; //Field offset: 0x88
	[SerializeField]
	private string _defaultSpriteShaderName; //Field offset: 0x90
	private SpriteRenderer spriteRenderer; //Field offset: 0x98
	private ClearStencilBufferComponent clearStencilComponent; //Field offset: 0xA0
	private MeshRenderer meshRenderer; //Field offset: 0xA8
	private bool isTypeApplyed; //Field offset: 0xB0
	private Material _maskMaterial; //Field offset: 0xB8
	private MeshFilter meshFilter; //Field offset: 0xC0
	private Nullable<Int32> parentStencilId; //Field offset: 0xC8
	private string instanceId; //Field offset: 0xD0
	private int _stencilId; //Field offset: 0xD8
	private int _level; //Field offset: 0xDC

	private Material defaultSpriteMaterial
	{
		private get { } //Length: 275
	}

	public bool inverted
	{
		 get { } //Length: 5
		 set { } //Length: 49
	}

	public bool isChild
	{
		 get { } //Length: 11
	}

	public virtual bool isEnabled
	{
		 get { } //Length: 7
	}

	public bool isRoot
	{
		 get { } //Length: 11
	}

	public int level
	{
		 get { } //Length: 7
	}

	public int maskIdPerLevel
	{
		 get { } //Length: 10
	}

	[Obsolete]
	public List<Transform> maskingRoots
	{
		 get { } //Length: 5
	}

	private Material maskMaterial
	{
		private get { } //Length: 323
	}

	public int maskRenderQueue
	{
		 get { } //Length: 13
	}

	public Vector2 pivot
	{
		 get { } //Length: 966
		 set { } //Length: 193
	}

	public bool showMaskGraphics
	{
		 get { } //Length: 5
		 set { } //Length: 77
	}

	public Vector2 size
	{
		 get { } //Length: 684
		 set { } //Length: 193
	}

	public Sprite sprite
	{
		 get { } //Length: 5
		 set { } //Length: 229
	}

	public int spriteRenderQueue
	{
		 get { } //Length: 13
	}

	public Shader spritesShader
	{
		 get { } //Length: 35
		 set { } //Length: 578
	}

	public int stencilId
	{
		 get { } //Length: 7
	}

	public Texture2D texture
	{
		 get { } //Length: 5
		 set { } //Length: 238
	}

	public Type type
	{
		 get { } //Length: 4
		 set { } //Length: 25
	}

	private static SpriteMask() { }

	public SpriteMask() { }

	private void applyType() { }

	private void Awake() { }

	private void clearChildsMaterial(Transform t) { }

	private void clearMaterial(Material m) { }

	private void destroyMeshComponents() { }

	private void destroySpriteComponents() { }

	protected virtual void doUpdateSprite(Transform t, CompareFunction comp, int stencil) { }

	private void ensureMeshComponents() { }

	private void ensureSpriteRenderer() { }

	private Material get_defaultSpriteMaterial() { }

	public bool get_inverted() { }

	public bool get_isChild() { }

	public virtual bool get_isEnabled() { }

	public bool get_isRoot() { }

	public int get_level() { }

	public int get_maskIdPerLevel() { }

	public List<Transform> get_maskingRoots() { }

	private Material get_maskMaterial() { }

	public int get_maskRenderQueue() { }

	public Vector2 get_pivot() { }

	public bool get_showMaskGraphics() { }

	public Vector2 get_size() { }

	public Sprite get_sprite() { }

	public int get_spriteRenderQueue() { }

	public Shader get_spritesShader() { }

	public int get_stencilId() { }

	public Texture2D get_texture() { }

	public Type get_type() { }

	private int getId(int level) { }

	private Material getIndividualMaterial(Material origin) { }

	private static SpriteMaskingComponent getMaskingComponent(Component t) { }

	public static SpriteMask getParentMask(Transform t) { }

	public Vector2 getPivot(Bounds bounds) { }

	public Renderer getRenderer() { }

	private static Renderer getRenderer(Component c) { }

	private static SpriteMask getSpriteMask(Component t) { }

	private static bool hasMaskingPart(Component t) { }

	private static bool hasSkipMasking(Component t) { }

	private bool hasStencilSupport(Material m) { }

	private void maybeDestroyRuntimeMesh() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private string readOwnerId(string str) { }

	private void releaseId(int id) { }

	public void set_inverted(bool value) { }

	public void set_pivot(Vector2 value) { }

	public void set_showMaskGraphics(bool value) { }

	public void set_size(Vector2 value) { }

	public void set_sprite(Sprite value) { }

	public void set_spritesShader(Shader value) { }

	public void set_texture(Texture2D value) { }

	public void set_type(Type value) { }

	private void Start() { }

	public void update() { }

	public static SpriteMask updateFor(Transform t) { }

	[ContextMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void updateMask() { }

	public void updateMaskingComponents() { }

	private void updateMaterial(Material m, Nullable<Int32> stencil, Nullable<CompareFunction> comp, Nullable<Int32> readMask) { }

	private void updateMeshSize() { }

	public void updateSprites(Transform trans) { }

	[ContextMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void updateSprites() { }

}


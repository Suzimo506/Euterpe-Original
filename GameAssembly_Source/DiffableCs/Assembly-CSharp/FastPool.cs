//Type is in global namespace

public class FastPool
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; //Field offset: 0x14
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject sourcePrefab; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int Capacity; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int PreloadCount; //Field offset: 0x24
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public PoolItemNotificationType NotificationType; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool WarmOnLoad; //Field offset: 0x2C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool ParentOnCache; //Field offset: 0x2D
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool useCustomID; //Field offset: 0x2E
	[HideInInspector]
	[SerializeField]
	private int customID; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private int cached_internal; //Field offset: 0x34
	private Stack<GameObject> cache; //Field offset: 0x38
	[CompilerGenerated]
	private Transform <parentTransform>k__BackingField; //Field offset: 0x40
	public List<GameObject> gameObjects; //Field offset: 0x48

	public List<GameObject> cached
	{
		 get { } //Length: 57
	}

	public int Cached
	{
		 get { } //Length: 59
	}

	public private int ID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsValid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 29
	}

	public private Transform parentTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public FastPool(int id, GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0) { }

	public FastPool(GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0) { }

	public void ClearCache() { }

	public void FastDestroy(GameObject sceneObject) { }

	public void FastDestroy(T sceneObject) { }

	public void FastDestroyAll() { }

	public GameObject FastInstantiate(Vector3 position, Quaternion rotation, Transform parent = null, Action<GameObject> callback = null) { }

	public GameObject FastInstantiate(Transform parent = null, Action<GameObject> callback = null) { }

	public T FastInstantiate(Vector3 position, Quaternion rotation, Transform parent = null, Action<GameObject> callback = null) { }

	public T FastInstantiate(Transform parent = null, Action<GameObject> callback = null) { }

	public List<GameObject> get_cached() { }

	public int get_Cached() { }

	[CompilerGenerated]
	public int get_ID() { }

	[CompilerGenerated]
	public bool get_IsValid() { }

	public string get_Name() { }

	[CompilerGenerated]
	public Transform get_parentTransform() { }

	public bool Init(Transform rootTransform) { }

	private void Init(GameObject go) { }

	private GameObject MakeClone(Vector3 position, Quaternion rotation, Transform parent) { }

	[CompilerGenerated]
	private void set_ID(int value) { }

	[CompilerGenerated]
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	private void set_parentTransform(Transform value) { }

}


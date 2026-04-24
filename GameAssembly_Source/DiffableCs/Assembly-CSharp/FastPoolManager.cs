//Type is in global namespace

public class FastPoolManager : SingletonMonoBehaviour<FastPoolManager>
{
	[SerializeField]
	private List<FastPool> predefinedPools; //Field offset: 0x18
	private Dictionary<Int32, FastPool> pools; //Field offset: 0x20
	private Transform curTransform; //Field offset: 0x28

	public Dictionary<Int32, FastPool> Pools
	{
		 get { } //Length: 5
	}

	public FastPoolManager() { }

	private void Awake() { }

	public static FastPool CreatePool(GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0, Transform newRootTransform = null) { }

	public static FastPool CreatePool(int id, GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0) { }

	public static FastPool CreatePoolC(T component, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0, Transform newRootTransform = null) { }

	public static void DestroyPool(FastPool pool) { }

	public Dictionary<Int32, FastPool> get_Pools() { }

	public static FastPool GetPool(GameObject prefab, bool createIfNotExists = true) { }

	public static FastPool GetPool(int id, GameObject prefab, bool createIfNotExists = true) { }

	public static FastPool GetPool(Component component, bool createIfNotExists = true) { }

	private void Start() { }

}


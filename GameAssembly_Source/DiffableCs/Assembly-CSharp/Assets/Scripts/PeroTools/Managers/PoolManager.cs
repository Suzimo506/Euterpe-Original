namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PoolManager : Singleton<PoolManager>
{
	[CompilerGenerated]
	private Dictionary<String, FastPool> <fastPools>k__BackingField; //Field offset: 0x10

	public private Dictionary<String, FastPool> fastPools
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public FastPool Item
	{
		 get { } //Length: 123
	}

	public PoolManager() { }

	public void DestroyFastPool(FastPool pool) { }

	public void DestroyFastPool(string uid) { }

	public void FastDestroy(GameObject gameObject) { }

	public GameObject FastInstantiate(string name, int preload, int capacity = -1, Transform parent = null) { }

	public GameObject FastInstantiate(GameObject go, int preload, int capacity = -1, Transform parent = null) { }

	[CompilerGenerated]
	public Dictionary<String, FastPool> get_fastPools() { }

	public FastPool get_Item(string name) { }

	private void Init() { }

	public FastPool MakeFastPool(T source, int preload, int capacity = -1, Transform parent = null) { }

	public FastPool MakeFastPool(GameObject source, int preload, int capacity = -1, Transform parent = null) { }

	public FastPool MakeFastPool(string name, int preload, int capacity, Transform parent = null) { }

	[CompilerGenerated]
	private void set_fastPools(Dictionary<String, FastPool> value) { }

}


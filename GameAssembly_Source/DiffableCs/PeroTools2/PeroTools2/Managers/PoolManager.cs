namespace PeroTools2.Managers;

[Obsolete]
public class PoolManager : Singleton<PoolManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public T source; //Field offset: 0x0
		public Transform parent; //Field offset: 0x0
		public Action<T> initAction; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal T <MakePool>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public GameObject source; //Field offset: 0x10
		public Transform parent; //Field offset: 0x18
		public Action<GameObject> initAction; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal GameObject <MakePool>b__0() { }

	}

	public const int preload_const = 10; //Field offset: 0x0
	private readonly Dictionary<String, Pool`1<GameObject>> m_GameObjectPools; //Field offset: 0x10
	private readonly Hashtable m_ComponentPools; //Field offset: 0x18

	public PoolManager() { }

	public void DestroyPool(Pool<GameObject> pool) { }

	public void DestroyPool(string name) { }

	public void DestroyPool(Pool<T> pool) { }

	public void DestroyPool(string name) { }

	public void FastDestroy(GameObject gameObject) { }

	public void FastDestroy(T component) { }

	public GameObject FastInstantiate(string name, int _preload = 10, Transform parent = null, Action<GameObject> initAction = null, Action<GameObject> releaseAction = null) { }

	public GameObject FastInstantiate(GameObject gameObject, int _preload = 10, Transform parent = null, Action<GameObject> initAction = null, Action<GameObject> releaseAction = null) { }

	public T FastInstantiate(T component, int _preload = 10, Transform parent = null, Action<T> initAction = null, Action<T> releaseAction = null) { }

	public T FastInstantiate(string name) { }

	public Pool<GameObject> MakePool(GameObject source, int preload = 10, Transform parent = null, Action<GameObject> initAction = null, Action<GameObject> pushAction = null, Action<GameObject> popAction = null) { }

	public Pool<GameObject> MakePool(string name, int preload = 10, Transform parent = null, Action<GameObject> initAction = null, Action<GameObject> pushAction = null, Action<GameObject> popAction = null) { }

	public Pool<T> MakePool(T source, int preload = 10, Transform parent = null, Action<T> initAction = null, Action<T> pushAction = null, Action<T> popAction = null) { }

	public Pool<T> MakePool(string name) { }

}


namespace PeroTools2.Resources;

public class ResourcesManager : SerializedScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IResourceLocation, String> <>9__26_0; //Field offset: 0x8
		public static Action<Object> <>9__37_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <CollectDependencies>b__26_0(IResourceLocation d) { }

		internal void <LoadFromTypeInternal>b__37_0(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public AsyncOperationHandle<IResourceLocator> handle; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <InitCoroutine>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public List<String> catalogsToUpdate; //Field offset: 0x10
		public AsyncOperationHandle<List`1<String>> hotfixHandle; //Field offset: 0x18
		public AsyncOperationHandle<Int64> handle; //Field offset: 0x38
		public List<Object> keys; //Field offset: 0x58

		public <>c__DisplayClass18_0() { }

		internal void <HotfixCoroutine>b__0(AsyncOperationHandle<List`1<String>> op) { }

		internal bool <HotfixCoroutine>b__1() { }

		internal bool <HotfixCoroutine>b__2() { }

		internal AsyncOperationHandle <HotfixCoroutine>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_1
	{
		public AsyncOperationHandle<List`1<IResourceLocator>> updateCatalogsHandle; //Field offset: 0x10

		public <>c__DisplayClass18_1() { }

		internal bool <HotfixCoroutine>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public object asset; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <LoadDependenciesAndAssets>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public AsyncOperationHandle<SceneInstance> handle; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <LoadDependenciesAndScene>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_1
	{
		public AsyncOperationHandle<Object> loadHandle; //Field offset: 0x10

		public <>c__DisplayClass23_1() { }

		internal bool <LoadDependenciesAndScene>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public AsyncOperationHandle<SceneInstance> handle; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <LoadSecneDependenciesAndAssets>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_1
	{
		public object asset; //Field offset: 0x10

		public <>c__DisplayClass25_1() { }

		internal void <LoadSecneDependenciesAndAssets>b__1(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ResourcesManager <>4__this; //Field offset: 0x0
		public string assetName; //Field offset: 0x0
		public Action<T> callback; //Field offset: 0x0

		public <>c__DisplayClass31_0`1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_1
	{
		public AsyncOperationHandle<T> handle; //Field offset: 0x0
		public <>c__DisplayClass31_0<T> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass31_1`1() { }

		internal void <LoadFromNameInternal>b__0() { }

		internal bool <LoadFromNameInternal>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Action<List`1<T>> callback; //Field offset: 0x0

		public <>c__DisplayClass34_0`1() { }

		internal void <LoadFromTypeAsync>b__0(List<Object> objs) { }

	}

	[CompilerGenerated]
	private sealed class <HotfixCoroutine>d__18 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x18
		private <>c__DisplayClass18_1 <>8__2; //Field offset: 0x20
		public Action<PatchInfo> callback; //Field offset: 0x28
		private PatchInfo <patchInfo>5__2; //Field offset: 0x30

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <HotfixCoroutine>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <InitCoroutine>d__16 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <InitCoroutine>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadDependenciesAndAssets>d__21 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public ResourcesManager <>4__this; //Field offset: 0x18
		public List<Object> deps; //Field offset: 0x20
		public PreloadInfo info; //Field offset: 0x28
		public int count; //Field offset: 0x30
		private <>c__DisplayClass21_0 <>8__1; //Field offset: 0x38
		public Action<List`1<Object>> callBack; //Field offset: 0x40
		private List<Object> <results>5__2; //Field offset: 0x48
		private int <i>5__3; //Field offset: 0x50

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <LoadDependenciesAndAssets>d__21(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadDependenciesAndScene>d__23 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public List<Object> deps; //Field offset: 0x18
		public PreloadInfo info; //Field offset: 0x20
		private <>c__DisplayClass23_0 <>8__1; //Field offset: 0x28
		public string sceneName; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <LoadDependenciesAndScene>d__23(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadFromTypeInternal>d__37 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public ResourcesManager <>4__this; //Field offset: 0x18
		public Type type; //Field offset: 0x20
		public Action<List`1<Object>> callback; //Field offset: 0x28
		public List<Object> objs; //Field offset: 0x30
		private Action<Object> <onLoaded>5__2; //Field offset: 0x38
		private Enumerator<String, AssetData> <>7__wrap2; //Field offset: 0x40
		private object <obj>5__4; //Field offset: 0x68

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <LoadFromTypeInternal>d__37(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadSecneDependenciesAndAssets>d__25 : IEnumerator<Single>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private float <>2__current; //Field offset: 0x14
		public ResourcesManager <>4__this; //Field offset: 0x18
		public List<Object> deps; //Field offset: 0x20
		public PreloadInfo info; //Field offset: 0x28
		public int count; //Field offset: 0x30
		private <>c__DisplayClass25_1 <>8__1; //Field offset: 0x38
		private <>c__DisplayClass25_0 <>8__2; //Field offset: 0x40
		public string sceneName; //Field offset: 0x48
		public Action<List`1<Object>> callback; //Field offset: 0x50
		private List<Object> <results>5__2; //Field offset: 0x58
		private int <i>5__3; //Field offset: 0x60

		private override float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 70
		}

		[DebuggerHidden]
		public <LoadSecneDependenciesAndAssets>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class AssetData
	{
		public string path; //Field offset: 0x10
		public string guid; //Field offset: 0x18
		public Type type; //Field offset: 0x20

		public AssetData() { }

		public bool CheckData() { }

		public virtual string ToString() { }

	}

	internal interface IAssetPostprocessor
	{

		public void OnPostprocessAllAssets(String[] importedAssets, String[] deletedAssets, String[] movedAssets, String[] movedFromAssets) { }

	}

	internal class PatchInfo
	{
		internal enum PatchStatus
		{
			update_unavailable = 0,
			update_available = 1,
		}

		public long downloadSizeBytes; //Field offset: 0x10
		public PatchStatus status; //Field offset: 0x18
		public Func<AsyncOperationHandle> downloadResAction; //Field offset: 0x20

		public PatchInfo() { }

	}

	internal class PreloadInfo
	{
		public float percent; //Field offset: 0x10
		public bool isDone; //Field offset: 0x14
		public CoroutineHandle coroutine; //Field offset: 0x18

		public PreloadInfo() { }

	}

	private static ResourcesManager s_Instance; //Field offset: 0x0
	private static ResourcesManager s_EditorInstance; //Field offset: 0x8
	[SerializeField]
	private String[] m_Directories; //Field offset: 0x58
	[SerializeField]
	private String[] m_ExcludeDirectories; //Field offset: 0x60
	[SerializeField]
	private readonly String[] m_IgnoreExtensions; //Field offset: 0x68
	[SerializeField]
	private List<IAssetPostprocessor> m_AssetProcessor; //Field offset: 0x70
	[SerializeField]
	private bool m_AutoDetect; //Field offset: 0x78
	[SerializeField]
	private bool m_IsAddressablesIndexing; //Field offset: 0x79
	[SerializeField]
	private Dictionary<String, AssetData> m_AssetDatas; //Field offset: 0x80
	private Dictionary<String, String> m_Guid2AssetDataKey; //Field offset: 0x88
	private readonly Dictionary<String, Object> m_LoadedAssetHandles; //Field offset: 0x90

	public static ResourcesManager instance
	{
		 get { } //Length: 502
	}

	public ResourcesManager() { }

	private void CollectDependencies(String[] preloadAssets, List<Object> deps) { }

	public static ResourcesManager get_instance() { }

	public AssetData GetAssetData(string assetName) { }

	public Dictionary<String, AssetData> GetAssetDatas() { }

	public List<String> GetAssetNamesInPath(string path, Type type = null) { }

	public IList<IResourceLocation> GetResourceLocations(string assetName) { }

	public CoroutineHandle Hotfix(Action<PatchInfo> callback) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> HotfixCoroutine(Action<PatchInfo> callback) { }

	private CoroutineHandle Init() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> InitCoroutine() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> LoadDependenciesAndAssets(PreloadInfo info, int count, Action<List`1<Object>> callBack, List<Object> deps) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> LoadDependenciesAndScene(PreloadInfo info, string sceneName, List<Object> deps) { }

	public object LoadFromAssetReference(AssetReference assetReference, Type type) { }

	public T LoadFromAssetReference(AssetReference assetReference) { }

	public CoroutineHandle LoadFromAssetReferenceAsync(AssetReference assetReference, Action<T> callback) { }

	public T LoadFromName(string assetName) { }

	public object LoadFromName(string assetName, Type type) { }

	public CoroutineHandle LoadFromNameAsync(string assetName, Action<T> callback) { }

	private T LoadFromNameInternal(string assetName, Action<T> callback, out CoroutineHandle coroutine) { }

	public List<Object> LoadFromType(Type type, string path = null) { }

	public List<T> LoadFromType(string path = null) { }

	public CoroutineHandle LoadFromTypeAsync(Type type, Action<List`1<Object>> callback, string path = null) { }

	public CoroutineHandle LoadFromTypeAsync(Action<List`1<T>> callback, string path = null) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> LoadFromTypeInternal(List<Object> objs, Type type, Action<List`1<Object>> callback = null, string path = null) { }

	private List<Object> LoadFromTypeInternal(Type type, out CoroutineHandle coroutine, Action<List`1<Object>> callback = null, string path = null) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator<Single> LoadSecneDependenciesAndAssets(PreloadInfo info, string sceneName, int count, Action<List`1<Object>> callback, List<Object> deps) { }

	public void LogLoadedBundle() { }

	public PreloadInfo Preload(string sceneName, String[] assetsName, Action<List`1<Object>> callback) { }

	public PreloadInfo PreloadAssets(String[] assetsName, Action<List`1<Object>> callback) { }

	public PreloadInfo PreloadScene(string sceneName) { }

	public void Unload(object obj, bool isInResources = false) { }

	public AsyncOperation UnloadAll() { }

	public void UnloadBundle(string bundleName, bool useRegex = false, bool excludeScriptableObj = true) { }

	private void UnloadBundle(AssetBundle bundle, bool excludeScriptableObj) { }

}


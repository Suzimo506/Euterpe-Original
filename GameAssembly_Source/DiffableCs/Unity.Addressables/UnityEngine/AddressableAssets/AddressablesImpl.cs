namespace UnityEngine.AddressableAssets;

internal class AddressablesImpl : IEqualityComparer<IResourceLocation>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ResourceLocatorInfo, IResourceLocator> <>9__60_0; //Field offset: 0x8
		public static Func<ResourceLocatorInfo, Boolean> <>9__137_0; //Field offset: 0x10
		public static Func<ResourceLocatorInfo, String> <>9__137_1; //Field offset: 0x18
		public static Func<ResourceLocatorInfo, String> <>9__141_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <CleanBundleCache>b__141_0(ResourceLocatorInfo s) { }

		internal bool <get_CatalogsWithAvailableUpdates>b__137_0(ResourceLocatorInfo s) { }

		internal string <get_CatalogsWithAvailableUpdates>b__137_1(ResourceLocatorInfo s) { }

		internal IResourceLocator <get_ResourceLocators>b__60_0(ResourceLocatorInfo l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass103_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IList<IResourceLocation> locations; //Field offset: 0x18

		public <>c__DisplayClass103_0() { }

		internal AsyncOperationHandle<IList`1<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass105_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IEnumerable keys; //Field offset: 0x18
		public MergeMode mode; //Field offset: 0x20

		public <>c__DisplayClass105_0() { }

		internal AsyncOperationHandle<IList`1<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass110_0
	{
		public bool unloadSceneOpExcludeReleaseCallback; //Field offset: 0x0
		public AddressablesImpl <>4__this; //Field offset: 0x0

		public <>c__DisplayClass110_0`1() { }

		internal void <AutoReleaseHandleOnCompletion>b__0(AsyncOperationHandle<TObject> op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x20

		public <>c__DisplayClass112_0() { }

		internal AsyncOperationHandle<Boolean> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IList<IResourceLocation> locations; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x20

		public <>c__DisplayClass113_0() { }

		internal AsyncOperationHandle<Boolean> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IEnumerable keys; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x20

		public <>c__DisplayClass114_0() { }

		internal AsyncOperationHandle<Boolean> <ClearDependencyCacheAsync>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass119_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18
		public InstantiationParameters instantiateParameters; //Field offset: 0x20

		public <>c__DisplayClass119_0() { }

		internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IResourceLocation location; //Field offset: 0x18
		public InstantiationParameters instantiateParameters; //Field offset: 0x20

		public <>c__DisplayClass121_0() { }

		internal AsyncOperationHandle<GameObject> <InstantiateWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18
		public LoadSceneMode loadMode; //Field offset: 0x20
		public bool activateOnLoad; //Field offset: 0x24
		public int priority; //Field offset: 0x28

		public <>c__DisplayClass124_0() { }

		internal AsyncOperationHandle<SceneInstance> <LoadSceneWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public UnloadSceneOptions unloadOptions; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x1C

		public <>c__DisplayClass130_0() { }

		internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle completedHandle) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass131_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public UnloadSceneOptions unloadOptions; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x1C

		public <>c__DisplayClass131_0() { }

		internal AsyncOperationHandle<SceneInstance> <CreateUnloadSceneWithChain>b__0(AsyncOperationHandle<SceneInstance> completedHandle) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass138_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public bool autoReleaseHandle; //Field offset: 0x18
		public bool autoCleanBundleCache; //Field offset: 0x19

		public <>c__DisplayClass138_0() { }

		internal AsyncOperationHandle<List`1<IResourceLocator>> <UpdateCatalogs>b__0(AsyncOperationHandle<List`1<String>> depOp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public IResourceLocator loc; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <RemoveResourceLocator>b__0(ResourceLocatorInfo l) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public string catalogPath; //Field offset: 0x18
		public bool autoReleaseHandle; //Field offset: 0x20
		public string providerSuffix; //Field offset: 0x28

		public <>c__DisplayClass70_0() { }

		internal AsyncOperationHandle<IResourceLocator> <LoadContentCatalogAsync>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x0
		public object key; //Field offset: 0x0

		public <>c__DisplayClass76_0`1() { }

		internal AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IEnumerable keys; //Field offset: 0x18
		public MergeMode mode; //Field offset: 0x20
		public Type type; //Field offset: 0x28

		public <>c__DisplayClass80_0() { }

		internal AsyncOperationHandle<IList`1<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18
		public Type type; //Field offset: 0x20

		public <>c__DisplayClass82_0() { }

		internal AsyncOperationHandle<IList`1<IResourceLocation>> <LoadResourceLocationsWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x0
		public IEnumerable keys; //Field offset: 0x0
		public Action<TObject> callback; //Field offset: 0x0
		public MergeMode mode; //Field offset: 0x0
		public bool releaseDependenciesOnFailure; //Field offset: 0x0

		public <>c__DisplayClass85_0`1() { }

		internal AsyncOperationHandle<IList`1<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x0
		public object key; //Field offset: 0x0
		public Action<TObject> callback; //Field offset: 0x0
		public bool releaseDependenciesOnFailure; //Field offset: 0x0

		public <>c__DisplayClass87_0`1() { }

		internal AsyncOperationHandle<IList`1<TObject>> <LoadAssetsWithChain>b__0(AsyncOperationHandle op2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18

		public <>c__DisplayClass95_0() { }

		internal AsyncOperationHandle<Int64> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public IEnumerable keys; //Field offset: 0x18

		public <>c__DisplayClass96_0() { }

		internal AsyncOperationHandle<Int64> <GetDownloadSizeWithChain>b__0(AsyncOperationHandle op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public AddressablesImpl <>4__this; //Field offset: 0x10
		public object key; //Field offset: 0x18

		public <>c__DisplayClass99_0() { }

		internal AsyncOperationHandle<IList`1<IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(AsyncOperationHandle op) { }

	}

	private class LoadResourceLocationKeyOp : AsyncOperationBase<IList`1<IResourceLocation>>
	{
		private object m_Keys; //Field offset: 0x88
		private IList<IResourceLocation> m_locations; //Field offset: 0x90
		private AddressablesImpl m_Addressables; //Field offset: 0x98
		private Type m_ResourceType; //Field offset: 0xA0

		protected virtual string DebugName
		{
			 get { } //Length: 42
		}

		public LoadResourceLocationKeyOp() { }

		protected virtual void Execute() { }

		protected virtual string get_DebugName() { }

		public void Init(AddressablesImpl aa, Type t, object keys) { }

		protected virtual bool InvokeWaitForCompletion() { }

	}

	private class LoadResourceLocationKeysOp : AsyncOperationBase<IList`1<IResourceLocation>>
	{
		private IEnumerable m_Key; //Field offset: 0x88
		private MergeMode m_MergeMode; //Field offset: 0x90
		private IList<IResourceLocation> m_locations; //Field offset: 0x98
		private AddressablesImpl m_Addressables; //Field offset: 0xA0
		private Type m_ResourceType; //Field offset: 0xA8

		protected virtual string DebugName
		{
			 get { } //Length: 43
		}

		public LoadResourceLocationKeysOp() { }

		protected virtual void Execute() { }

		protected virtual string get_DebugName() { }

		public void Init(AddressablesImpl aa, Type t, IEnumerable key, MergeMode mergeMode) { }

		protected virtual bool InvokeWaitForCompletion() { }

	}

	internal class ResourceLocatorInfo
	{
		[CompilerGenerated]
		private IResourceLocator <Locator>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <LocalHash>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private IResourceLocation <CatalogLocation>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <ContentUpdateAvailable>k__BackingField; //Field offset: 0x28

		public bool CanUpdateContent
		{
			 get { } //Length: 154
		}

		public private IResourceLocation CatalogLocation
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public internal bool ContentUpdateAvailable
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 4
		}

		public IResourceLocation HashLocation
		{
			 get { } //Length: 97
		}

		public private string LocalHash
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private IResourceLocator Locator
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

		public bool get_CanUpdateContent() { }

		[CompilerGenerated]
		public IResourceLocation get_CatalogLocation() { }

		[CompilerGenerated]
		public bool get_ContentUpdateAvailable() { }

		public IResourceLocation get_HashLocation() { }

		[CompilerGenerated]
		public string get_LocalHash() { }

		[CompilerGenerated]
		public IResourceLocator get_Locator() { }

		[CompilerGenerated]
		private void set_CatalogLocation(IResourceLocation value) { }

		[CompilerGenerated]
		internal void set_ContentUpdateAvailable(bool value) { }

		[CompilerGenerated]
		private void set_LocalHash(string value) { }

		[CompilerGenerated]
		private void set_Locator(IResourceLocator value) { }

		internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }

	}

	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/"; //Field offset: 0x0
	private ResourceManager m_ResourceManager; //Field offset: 0x10
	private IInstanceProvider m_InstanceProvider; //Field offset: 0x18
	private int m_CatalogRequestsTimeout; //Field offset: 0x20
	public ISceneProvider SceneProvider; //Field offset: 0x28
	internal List<ResourceLocatorInfo> m_ResourceLocators; //Field offset: 0x30
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; //Field offset: 0x38
	private AsyncOperationHandle<List`1<String>> m_ActiveCheckUpdateOperation; //Field offset: 0x58
	internal AsyncOperationHandle<List`1<IResourceLocator>> m_ActiveUpdateOperation; //Field offset: 0x78
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; //Field offset: 0x98
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; //Field offset: 0xA0
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; //Field offset: 0xA8
	private Dictionary<Object, AsyncOperationHandle> m_resultToHandle; //Field offset: 0xB0
	internal HashSet<AsyncOperationHandle> m_SceneInstances; //Field offset: 0xB8
	private AsyncOperationHandle<Boolean> m_ActiveCleanBundleCacheOperation; //Field offset: 0xC0
	internal bool hasStartedInitialization; //Field offset: 0xE0

	public string BuildPath
	{
		 get { } //Length: 607
	}

	public int CatalogRequestsTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	internal IEnumerable<String> CatalogsWithAvailableUpdates
	{
		internal get { } //Length: 431
	}

	public AsyncOperationHandle ChainOperation
	{
		 get { } //Length: 424
	}

	public IInstanceProvider InstanceProvider
	{
		 get { } //Length: 5
		 set { } //Length: 126
	}

	public Func<IResourceLocation, String> InternalIdTransformFunc
	{
		 get { } //Length: 30
		 set { } //Length: 46
	}

	public string PlayerBuildDataPath
	{
		 get { } //Length: 100
	}

	public IEnumerable<IResourceLocator> ResourceLocators
	{
		 get { } //Length: 243
	}

	public ResourceManager ResourceManager
	{
		 get { } //Length: 145
	}

	public string RuntimePath
	{
		 get { } //Length: 100
	}

	internal int SceneOperationCount
	{
		internal get { } //Length: 62
	}

	internal bool ShouldChainRequest
	{
		internal get { } //Length: 166
	}

	public string StreamingAssetsSubFolder
	{
		 get { } //Length: 43
	}

	internal int TrackedHandleCount
	{
		internal get { } //Length: 70
	}

	public Action<UnityWebRequest> WebRequestOverride
	{
		 get { } //Length: 30
		 set { } //Length: 46
	}

	public AddressablesImpl(IAllocationStrategy alloc) { }

	[CompilerGenerated]
	private void <AutoReleaseHandleOnCompletion>b__108_0(AsyncOperationHandle op) { }

	[CompilerGenerated]
	private void <AutoReleaseHandleOnCompletion>b__109_0(AsyncOperationHandle<TObject> op) { }

	[CompilerGenerated]
	private void <AutoReleaseHandleOnTypelessCompletion>b__111_0(AsyncOperationHandle op) { }

	[CompilerGenerated]
	private void <TrackHandle>b__71_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null) { }

	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle<TObject> handle, bool unloadSceneOpExcludeReleaseCallback) { }

	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle<TObject> handle) { }

	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle) { }

	internal void AutoReleaseHandleOnTypelessCompletion(AsyncOperationHandle<TObject> handle) { }

	internal AsyncOperationHandle<List`1<String>> CheckForCatalogUpdates(bool autoReleaseHandle = true) { }

	internal AsyncOperationHandle<Boolean> CleanBundleCache(IEnumerable<String> catalogIds) { }

	internal AsyncOperationHandle<Boolean> CleanBundleCache(AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	public AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	public AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	public AsyncOperationHandle<Boolean> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	internal bool ClearDependencyCacheForKey(object key) { }

	public void ClearResourceLocators() { }

	internal void ClearTrackHandles() { }

	internal ResourceLocationBase CreateCatalogLocationWithHashDependencies(string catalogPath, string hashFilePath) { }

	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, MergeMode mode, bool autoReleaseHandle = false) { }

	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false) { }

	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false) { }

	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, MergeMode mode, bool autoReleaseHandle) { }

	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	public override bool Equals(IResourceLocation x, IResourceLocation y) { }

	private object EvaluateKey(object obj) { }

	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	public string get_BuildPath() { }

	public int get_CatalogRequestsTimeout() { }

	internal IEnumerable<String> get_CatalogsWithAvailableUpdates() { }

	public AsyncOperationHandle get_ChainOperation() { }

	public IInstanceProvider get_InstanceProvider() { }

	public Func<IResourceLocation, String> get_InternalIdTransformFunc() { }

	public string get_PlayerBuildDataPath() { }

	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	public ResourceManager get_ResourceManager() { }

	public string get_RuntimePath() { }

	internal int get_SceneOperationCount() { }

	internal bool get_ShouldChainRequest() { }

	public string get_StreamingAssetsSubFolder() { }

	internal int get_TrackedHandleCount() { }

	public Action<UnityWebRequest> get_WebRequestOverride() { }

	public AsyncOperationHandle<Int64> GetDownloadSizeAsync(object key) { }

	public AsyncOperationHandle<Int64> GetDownloadSizeAsync(IEnumerable keys) { }

	private AsyncOperationHandle<Int64> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	private AsyncOperationHandle<Int64> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	public override int GetHashCode(IResourceLocation loc) { }

	internal ResourceLocatorInfo GetLocatorInfo(string c) { }

	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation>& locations) { }

	internal bool GetResourceLocations(IEnumerable keys, Type type, MergeMode merge, out IList<IResourceLocation>& locations) { }

	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix = null, bool autoReleaseHandle = true) { }

	public AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true) { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true) { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true) { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true) { }

	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = true) { }

	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	public AsyncOperationHandle<TObject> LoadAssetAsync(IResourceLocation location) { }

	public AsyncOperationHandle<TObject> LoadAssetAsync(object key) { }

	public AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }

	public AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure) { }

	public AsyncOperationHandle<IList`1<TObject>> LoadAssetsAsync(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }

	private AsyncOperationHandle<IList`1<TObject>> LoadAssetsWithChain(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }

	private AsyncOperationHandle<IList`1<TObject>> LoadAssetsWithChain(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure) { }

	private AsyncOperationHandle<TObject> LoadAssetWithChain(AsyncOperationHandle dep, object key) { }

	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = true, string providerSuffix = null) { }

	public AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, MergeMode mode, Type type = null) { }

	public AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type = null) { }

	public AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, MergeMode mode, Type type) { }

	public AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100, bool trackHandle = true) { }

	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100, bool trackHandle = true) { }

	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneMode loadMode = 0, bool activateOnLoad = true, int priority = 100) { }

	public void Log(string msg) { }

	public void LogError(string msg) { }

	public void LogErrorFormat(string format, Object[] args) { }

	public void LogException(AsyncOperationHandle op, Exception ex) { }

	public void LogException(Exception ex) { }

	public void LogFormat(string format, Object[] args) { }

	public void LogWarning(string msg) { }

	public void LogWarningFormat(string format, Object[] args) { }

	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	internal void OnSceneUnloaded(Scene scene) { }

	public void Release(AsyncOperationHandle handle) { }

	public void Release(AsyncOperationHandle<TObject> handle) { }

	public void Release(TObject obj) { }

	public bool ReleaseInstance(GameObject instance) { }

	internal void ReleaseSceneManagerOperation() { }

	public void RemoveResourceLocator(IResourceLocator loc) { }

	public string ResolveInternalId(string id) { }

	public void set_CatalogRequestsTimeout(int value) { }

	public void set_InstanceProvider(IInstanceProvider value) { }

	public void set_InternalIdTransformFunc(Func<IResourceLocation, String> value) { }

	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	private AsyncOperationHandle<TObject> TrackHandle(AsyncOperationHandle<TObject> handle) { }

	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = true) { }

	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = true) { }

	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = true) { }

	internal AsyncOperationHandle<List`1<IResourceLocator>> UpdateCatalogs(IEnumerable<String> catalogIds = null, bool autoReleaseHandle = true, bool autoCleanBundleCache = false) { }

	internal static void WrapAsDownloadLocations(List<IResourceLocation> locations) { }

}


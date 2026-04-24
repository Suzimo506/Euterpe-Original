namespace UnityEngine.ResourceManagement.ResourceProviders;

internal class AssetBundleResource : IAssetBundleResource, IUpdateReceiver
{
	public enum LoadType
	{
		None = 0,
		Local = 1,
		Web = 2,
	}

	private const int k_WaitForWebRequestMainThreadSleep = 1; //Field offset: 0x0
	private AssetBundle m_AssetBundle; //Field offset: 0x10
	private DownloadHandlerAssetBundle m_downloadHandler; //Field offset: 0x18
	private AsyncOperation m_RequestOperation; //Field offset: 0x20
	private WebRequestQueueOperation m_WebRequestQueueOperation; //Field offset: 0x28
	internal ProvideHandle m_ProvideHandle; //Field offset: 0x30
	internal AssetBundleRequestOptions m_Options; //Field offset: 0x48
	private bool m_WebRequestCompletedCallbackCalled; //Field offset: 0x50
	private int m_Retries; //Field offset: 0x54
	private long m_BytesToDownload; //Field offset: 0x58
	private long m_DownloadedBytes; //Field offset: 0x60
	private bool m_Completed; //Field offset: 0x68
	private string m_TransformedInternalId; //Field offset: 0x70
	private AssetBundleRequest m_PreloadRequest; //Field offset: 0x78
	private bool m_PreloadCompleted; //Field offset: 0x80
	private ulong m_LastDownloadedByteCount; //Field offset: 0x88
	private float m_TimeoutTimer; //Field offset: 0x90
	private int m_TimeoutOverFrames; //Field offset: 0x94

	internal long BytesToDownload
	{
		internal get { } //Length: 169
	}

	private bool HasTimedOut
	{
		private get { } //Length: 61
	}

	public AssetBundleResource() { }

	[CompilerGenerated]
	private void <BeginOperation>b__34_0(UnityWebRequestAsyncOperation asyncOp) { }

	[CompilerGenerated]
	private void <GetAssetPreloadRequest>b__25_0(AsyncOperation operation) { }

	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	private void BeginOperation() { }

	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	private void CompleteBundleLoad(AssetBundle bundle) { }

	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	internal UnityWebRequest CreateWebRequest(string url) { }

	internal long get_BytesToDownload() { }

	private bool get_HasTimedOut() { }

	public override AssetBundle GetAssetBundle() { }

	internal AssetBundleRequest GetAssetPreloadRequest() { }

	private DownloadStatus GetDownloadStatus() { }

	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out LoadType loadType, out string path) { }

	internal static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path) { }

	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	private float PercentComplete() { }

	internal void Start(ProvideHandle provideHandle) { }

	public void Unload() { }

	public override void Update(float unscaledDeltaTime) { }

	private bool WaitForCompletionHandler() { }

	private void WebRequestOperationCompleted(AsyncOperation op) { }

}


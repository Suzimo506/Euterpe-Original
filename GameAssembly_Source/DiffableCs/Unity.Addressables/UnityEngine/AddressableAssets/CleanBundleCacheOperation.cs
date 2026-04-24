namespace UnityEngine.AddressableAssets;

internal class CleanBundleCacheOperation : AsyncOperationBase<Boolean>, IUpdateReceiver
{
	private AddressablesImpl m_Addressables; //Field offset: 0x88
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0x90
	private List<String> m_CacheDirsForRemoval; //Field offset: 0xB0
	private Thread m_EnumerationThread; //Field offset: 0xB8
	private string m_BaseCachePath; //Field offset: 0xC0

	public CleanBundleCacheOperation(AddressablesImpl aa) { }

	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	private void DetermineCacheDirsNotInUse(object data) { }

	protected virtual void Execute() { }

	private HashSet<String> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }

	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	protected virtual bool InvokeWaitForCompletion() { }

	private void RemoveCacheEntries() { }

	public AsyncOperationHandle<Boolean> Start(AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	private override void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

}


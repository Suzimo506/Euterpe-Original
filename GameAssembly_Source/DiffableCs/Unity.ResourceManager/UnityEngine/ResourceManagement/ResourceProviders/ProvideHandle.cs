namespace UnityEngine.ResourceManagement.ResourceProviders;

public struct ProvideHandle
{
	private int m_Version; //Field offset: 0x0
	private IGenericProviderOperation m_InternalOp; //Field offset: 0x8
	private ResourceManager m_ResourceManager; //Field offset: 0x10

	public int DependencyCount
	{
		 get { } //Length: 81
	}

	private IGenericProviderOperation InternalOp
	{
		private get { } //Length: 130
	}

	public IResourceLocation Location
	{
		 get { } //Length: 81
	}

	public ResourceManager ResourceManager
	{
		 get { } //Length: 5
	}

	public Type Type
	{
		 get { } //Length: 81
	}

	internal ProvideHandle(ResourceManager rm, IGenericProviderOperation op) { }

	public void Complete(T result, bool status, Exception exception) { }

	public int get_DependencyCount() { }

	private IGenericProviderOperation get_InternalOp() { }

	public IResourceLocation get_Location() { }

	public ResourceManager get_ResourceManager() { }

	public Type get_Type() { }

	public void GetDependencies(IList<Object> list) { }

	public TDepObject GetDependency(int index) { }

	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	public void SetProgressCallback(Func<Single> callback) { }

	public void SetWaitForCompletionCallback(Func<Boolean> callback) { }

}


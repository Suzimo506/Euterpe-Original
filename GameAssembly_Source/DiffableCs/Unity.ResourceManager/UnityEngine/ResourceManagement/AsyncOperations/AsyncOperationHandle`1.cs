namespace UnityEngine.ResourceManagement.AsyncOperations;

public struct AsyncOperationHandle : IEnumerator, IEquatable<AsyncOperationHandle`1<TObject>>
{
	internal AsyncOperationBase<TObject> m_InternalOp; //Field offset: 0x0
	private int m_Version; //Field offset: 0x0
	private string m_LocationName; //Field offset: 0x0
	private bool m_UnloadSceneOpExcludeReleaseCallback; //Field offset: 0x0

	public event Action<AsyncOperationHandle`1<TObject>> Completed
	{
		 add { } //Length: 190
		 remove { } //Length: 190
	}

	public event Action<AsyncOperationHandle> CompletedTypeless
	{
		 add { } //Length: 190
		 remove { } //Length: 190
	}

	public event Action<AsyncOperationHandle> Destroyed
	{
		 add { } //Length: 190
		 remove { } //Length: 190
	}

	public string DebugName
	{
		 get { } //Length: 200
	}

	private AsyncOperationBase<TObject> InternalOp
	{
		private get { } //Length: 221
	}

	public bool IsDone
	{
		 get { } //Length: 234
	}

	internal string LocationName
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	public Exception OperationException
	{
		 get { } //Length: 178
	}

	public float PercentComplete
	{
		 get { } //Length: 178
	}

	internal int ReferenceCount
	{
		internal get { } //Length: 178
	}

	public TObject Result
	{
		 get { } //Length: 178
	}

	public AsyncOperationStatus Status
	{
		 get { } //Length: 178
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 149
	}

	public Task<TObject> Task
	{
		 get { } //Length: 178
	}

	internal bool UnloadSceneOpExcludeReleaseCallback
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal AsyncOperationHandle`1(IAsyncOperation op, string locationName) { }

	internal AsyncOperationHandle`1(IAsyncOperation op, int version, string locationName) { }

	internal AsyncOperationHandle`1(AsyncOperationBase<TObject> op) { }

	internal AsyncOperationHandle`1(IAsyncOperation op, int version) { }

	internal AsyncOperationHandle`1(IAsyncOperation op) { }

	internal AsyncOperationHandle<TObject> Acquire() { }

	public void add_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	public override bool Equals(AsyncOperationHandle<TObject> other) { }

	public string get_DebugName() { }

	private AsyncOperationBase<TObject> get_InternalOp() { }

	public bool get_IsDone() { }

	internal string get_LocationName() { }

	public Exception get_OperationException() { }

	public float get_PercentComplete() { }

	internal int get_ReferenceCount() { }

	public TObject get_Result() { }

	public AsyncOperationStatus get_Status() { }

	public Task<TObject> get_Task() { }

	internal bool get_UnloadSceneOpExcludeReleaseCallback() { }

	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	public DownloadStatus GetDownloadStatus() { }

	public virtual int GetHashCode() { }

	internal DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited) { }

	public bool IsValid() { }

	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }

	internal void Release() { }

	public void remove_Completed(Action<AsyncOperationHandle`1<TObject>> value) { }

	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }

	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	internal void set_LocationName(string value) { }

	internal void set_UnloadSceneOpExcludeReleaseCallback(bool value) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

	public TObject WaitForCompletion() { }

}


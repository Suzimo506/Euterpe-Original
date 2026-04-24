namespace UnityEngine.ResourceManagement.AsyncOperations;

public struct AsyncOperationHandle : IEnumerator
{
	private static bool m_IsWaitingForCompletion; //Field offset: 0x0
	internal IAsyncOperation m_InternalOp; //Field offset: 0x0
	private int m_Version; //Field offset: 0x8
	private string m_LocationName; //Field offset: 0x10

	public event Action<AsyncOperationHandle> Completed
	{
		 add { } //Length: 96
		 remove { } //Length: 96
	}

	public event Action<AsyncOperationHandle> Destroyed
	{
		 add { } //Length: 96
		 remove { } //Length: 96
	}

	public string DebugName
	{
		 get { } //Length: 247
	}

	private IAsyncOperation InternalOp
	{
		private get { } //Length: 123
	}

	public bool IsDone
	{
		 get { } //Length: 242
	}

	internal static bool IsWaitingForCompletion
	{
		internal get { } //Length: 182
		internal set { } //Length: 91
	}

	internal string LocationName
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	public Exception OperationException
	{
		 get { } //Length: 193
	}

	public float PercentComplete
	{
		 get { } //Length: 193
	}

	internal int ReferenceCount
	{
		internal get { } //Length: 81
	}

	public object Result
	{
		 get { } //Length: 78
	}

	public AsyncOperationStatus Status
	{
		 get { } //Length: 81
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 78
	}

	public Task<Object> Task
	{
		 get { } //Length: 193
	}

	private static AsyncOperationHandle() { }

	internal AsyncOperationHandle(IAsyncOperation op) { }

	internal AsyncOperationHandle(IAsyncOperation op, int version) { }

	internal AsyncOperationHandle(IAsyncOperation op, string locationName) { }

	internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName) { }

	internal AsyncOperationHandle Acquire() { }

	public void add_Completed(Action<AsyncOperationHandle> value) { }

	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	public AsyncOperationHandle<T> Convert() { }

	public bool Equals(AsyncOperationHandle other) { }

	public string get_DebugName() { }

	private IAsyncOperation get_InternalOp() { }

	public bool get_IsDone() { }

	internal static bool get_IsWaitingForCompletion() { }

	internal string get_LocationName() { }

	public Exception get_OperationException() { }

	public float get_PercentComplete() { }

	internal int get_ReferenceCount() { }

	public object get_Result() { }

	public AsyncOperationStatus get_Status() { }

	public Task<Object> get_Task() { }

	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	public DownloadStatus GetDownloadStatus() { }

	public virtual int GetHashCode() { }

	internal DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited) { }

	public bool IsValid() { }

	internal void Release() { }

	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	internal static void set_IsWaitingForCompletion(bool value) { }

	internal void set_LocationName(string value) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

	public object WaitForCompletion() { }

}


namespace System.Threading.Tasks;

internal class SystemThreadingTasks_FutureDebugView
{
	private Task<TResult> m_task; //Field offset: 0x0

	public object AsyncState
	{
		 get { } //Length: 27
	}

	public bool CancellationPending
	{
		 get { } //Length: 82
	}

	public TaskCreationOptions CreationOptions
	{
		 get { } //Length: 29
	}

	public Exception Exception
	{
		 get { } //Length: 29
	}

	public int Id
	{
		 get { } //Length: 29
	}

	public TResult Result
	{
		 get { } //Length: 94
	}

	public TaskStatus Status
	{
		 get { } //Length: 29
	}

	public SystemThreadingTasks_FutureDebugView`1(Task<TResult> task) { }

	public object get_AsyncState() { }

	public bool get_CancellationPending() { }

	public TaskCreationOptions get_CreationOptions() { }

	public Exception get_Exception() { }

	public int get_Id() { }

	public TResult get_Result() { }

	public TaskStatus get_Status() { }

}


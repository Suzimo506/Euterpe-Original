namespace System.Threading.Tasks;

internal class SystemThreadingTasks_TaskDebugView
{
	private Task m_task; //Field offset: 0x10

	public object AsyncState
	{
		 get { } //Length: 27
	}

	public bool CancellationPending
	{
		 get { } //Length: 95
	}

	public TaskCreationOptions CreationOptions
	{
		 get { } //Length: 94
	}

	public Exception Exception
	{
		 get { } //Length: 83
	}

	public int Id
	{
		 get { } //Length: 29
	}

	public TaskStatus Status
	{
		 get { } //Length: 29
	}

	public SystemThreadingTasks_TaskDebugView(Task task) { }

	public object get_AsyncState() { }

	public bool get_CancellationPending() { }

	public TaskCreationOptions get_CreationOptions() { }

	public Exception get_Exception() { }

	public int get_Id() { }

	public TaskStatus get_Status() { }

}


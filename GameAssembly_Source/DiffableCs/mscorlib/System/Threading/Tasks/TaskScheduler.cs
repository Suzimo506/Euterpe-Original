namespace System.Threading.Tasks;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class TaskScheduler
{
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{
		private readonly TaskScheduler m_taskScheduler; //Field offset: 0x10

		public int Id
		{
			 get { } //Length: 29
		}

		public IEnumerable<Task> ScheduledTasks
		{
			 get { } //Length: 39
		}

		public SystemThreadingTasks_TaskSchedulerDebugView(TaskScheduler scheduler) { }

		public int get_Id() { }

		public IEnumerable<Task> get_ScheduledTasks() { }

	}

	private static ConditionalWeakTable<TaskScheduler, Object> s_activeTaskSchedulers; //Field offset: 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x8
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0x18
	private static readonly object _unobservedTaskExceptionLockObject; //Field offset: 0x20
	private int m_taskSchedulerId; //Field offset: 0x10

	public static TaskScheduler Current
	{
		 get { } //Length: 196
	}

	public static TaskScheduler Default
	{
		 get { } //Length: 87
	}

	public int Id
	{
		 get { } //Length: 171
	}

	internal static TaskScheduler InternalCurrent
	{
		internal get { } //Length: 179
	}

	internal override bool RequiresAtomicStartTransition
	{
		internal get { } //Length: 3
	}

	private static TaskScheduler() { }

	protected TaskScheduler() { }

	private void AddToActiveTaskSchedulers() { }

	public static TaskScheduler get_Current() { }

	public static TaskScheduler get_Default() { }

	public int get_Id() { }

	internal static TaskScheduler get_InternalCurrent() { }

	internal override bool get_RequiresAtomicStartTransition() { }

	protected abstract IEnumerable<Task> GetScheduledTasks() { }

	internal void InternalQueueTask(Task task) { }

	internal override void NotifyWorkItemProgress() { }

	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	protected private abstract void QueueTask(Task task) { }

	protected private override bool TryDequeue(Task task) { }

	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}


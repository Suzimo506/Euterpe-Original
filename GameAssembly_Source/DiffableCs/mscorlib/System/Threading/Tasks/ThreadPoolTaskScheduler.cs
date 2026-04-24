namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	private sealed class <FilterTasksFromWorkItems>d__7 : IEnumerable<Task>, IEnumerable, IEnumerator<Task>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Task <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable<IThreadPoolWorkItem> tpwItems; //Field offset: 0x28
		public IEnumerable<IThreadPoolWorkItem> <>3__tpwItems; //Field offset: 0x30
		private IEnumerator<IThreadPoolWorkItem> <>7__wrap1; //Field offset: 0x38

		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <FilterTasksFromWorkItems>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Task> System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>.GetEnumerator() { }

		[DebuggerHidden]
		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x6B0DC

	internal virtual bool RequiresAtomicStartTransition
	{
		internal get { } //Length: 3
	}

	private static ThreadPoolTaskScheduler() { }

	internal ThreadPoolTaskScheduler() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerable<Task> FilterTasksFromWorkItems(IEnumerable<IThreadPoolWorkItem> tpwItems) { }

	internal virtual bool get_RequiresAtomicStartTransition() { }

	protected virtual IEnumerable<Task> GetScheduledTasks() { }

	private static void LongRunningThreadWork(object obj) { }

	internal virtual void NotifyWorkItemProgress() { }

	protected private virtual void QueueTask(Task task) { }

	protected private virtual bool TryDequeue(Task task) { }

	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}


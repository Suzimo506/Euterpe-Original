namespace System.Threading;

public static class ThreadPool
{
	[CompilerGenerated]
	private sealed class <EnumerateQueuedWorkItems>d__21 : IEnumerable<IThreadPoolWorkItem>, IEnumerable, IEnumerator<IThreadPoolWorkItem>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private IThreadPoolWorkItem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private WorkStealingQueue[] wsQueues; //Field offset: 0x28
		public WorkStealingQueue[] <>3__wsQueues; //Field offset: 0x30
		private IThreadPoolWorkItem[] <items>5__1; //Field offset: 0x38
		private int <i>5__2; //Field offset: 0x40
		private QueueSegment globalQueueTail; //Field offset: 0x48
		public QueueSegment <>3__globalQueueTail; //Field offset: 0x50
		private IThreadPoolWorkItem[] <items>5__3; //Field offset: 0x58
		private int <i>5__4; //Field offset: 0x60
		private QueueSegment <segment>5__5; //Field offset: 0x68
		private WorkStealingQueue[] <>7__wrap1; //Field offset: 0x70
		private int <>7__wrap2; //Field offset: 0x78

		private override IThreadPoolWorkItem System.Collections.Generic.IEnumerator<System.Threading.IThreadPoolWorkItem>.Current
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
		public <EnumerateQueuedWorkItems>d__21(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<IThreadPoolWorkItem> System.Collections.Generic.IEnumerable<System.Threading.IThreadPoolWorkItem>.GetEnumerator() { }

		[DebuggerHidden]
		private override IThreadPoolWorkItem System.Collections.Generic.IEnumerator<System.Threading.IThreadPoolWorkItem>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	private static void EnsureVMInitialized() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static IEnumerable<IThreadPoolWorkItem> EnumerateQueuedWorkItems(WorkStealingQueue[] wsQueues, QueueSegment globalQueueTail) { }

	internal static IEnumerable<IThreadPoolWorkItem> GetQueuedWorkItems() { }

	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	internal static bool IsThreadPoolHosted() { }

	internal static bool NotifyWorkItemComplete() { }

	internal static void NotifyWorkItemProgress() { }

	internal static void NotifyWorkItemProgressNative() { }

	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	internal static void ReportThreadStatus(bool isWorking) { }

	internal static bool RequestWorkerThread() { }

	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

}


namespace System.Net;

internal class SimpleAsyncResult : IAsyncResult
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Func<SimpleAsyncResult, Boolean> func; //Field offset: 0x10
		public object locker; //Field offset: 0x18
		public SimpleAsyncCallback callback; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

		internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public AsyncCallback cb; //Field offset: 0x10
		public SimpleAsyncResult <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <.ctor>b__0(SimpleAsyncResult result) { }

	}

	private ManualResetEvent handle; //Field offset: 0x10
	private bool synch; //Field offset: 0x18
	private bool isCompleted; //Field offset: 0x19
	private readonly SimpleAsyncCallback cb; //Field offset: 0x20
	private object state; //Field offset: 0x28
	private bool callbackDone; //Field offset: 0x30
	private Exception exc; //Field offset: 0x38
	private object locker; //Field offset: 0x40
	private Nullable<Boolean> user_read_synch; //Field offset: 0x48

	public override object AsyncState
	{
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 238
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 110
	}

	internal bool CompletedSynchronouslyPeek
	{
		internal get { } //Length: 5
	}

	internal Exception Exception
	{
		internal get { } //Length: 5
	}

	internal bool GotException
	{
		internal get { } //Length: 9
	}

	public override bool IsCompleted
	{
		 get { } //Length: 140
	}

	private SimpleAsyncResult(SimpleAsyncCallback cb) { }

	protected SimpleAsyncResult(AsyncCallback cb, object state) { }

	protected void DoCallback_internal() { }

	private void DoCallback_private() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	internal bool get_CompletedSynchronouslyPeek() { }

	internal Exception get_Exception() { }

	internal bool get_GotException() { }

	public override bool get_IsCompleted() { }

	protected void Reset_internal() { }

	public static void Run(Func<SimpleAsyncResult, Boolean> func, SimpleAsyncCallback callback) { }

	public static void RunWithLock(object locker, Func<SimpleAsyncResult, Boolean> func, SimpleAsyncCallback callback) { }

	internal void SetCompleted(bool synch, Exception e) { }

	internal void SetCompleted(bool synch) { }

	private void SetCompleted_internal(bool synch, Exception e) { }

	protected void SetCompleted_internal(bool synch) { }

	internal void WaitUntilComplete() { }

	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

}


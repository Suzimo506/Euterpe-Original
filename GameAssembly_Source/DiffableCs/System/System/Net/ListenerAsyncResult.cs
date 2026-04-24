namespace System.Net;

internal class ListenerAsyncResult : IAsyncResult
{
	private static WaitCallback InvokeCB; //Field offset: 0x0
	private ManualResetEvent handle; //Field offset: 0x10
	private bool synch; //Field offset: 0x18
	private bool completed; //Field offset: 0x19
	private AsyncCallback cb; //Field offset: 0x20
	private object state; //Field offset: 0x28
	private Exception exception; //Field offset: 0x30
	private HttpListenerContext context; //Field offset: 0x38
	private object locker; //Field offset: 0x40
	private ListenerAsyncResult forward; //Field offset: 0x48
	internal bool EndCalled; //Field offset: 0x50
	internal bool InGet; //Field offset: 0x51

	public override object AsyncState
	{
		 get { } //Length: 24
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 260
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 24
	}

	public override bool IsCompleted
	{
		 get { } //Length: 169
	}

	private static ListenerAsyncResult() { }

	public ListenerAsyncResult(AsyncCallback cb, object state) { }

	internal void Complete(Exception exc) { }

	internal void Complete(HttpListenerContext context) { }

	internal void Complete(HttpListenerContext context, bool synch) { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	public override bool get_IsCompleted() { }

	internal HttpListenerContext GetContext() { }

	private static void InvokeCallback(object o) { }

}


namespace System.Net;

internal sealed class SimpleAsyncCallback : MulticastDelegate
{

	public SimpleAsyncCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(SimpleAsyncResult result, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(SimpleAsyncResult result) { }

}


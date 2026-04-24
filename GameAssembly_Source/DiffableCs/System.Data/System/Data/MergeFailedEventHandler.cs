namespace System.Data;

public sealed class MergeFailedEventHandler : MulticastDelegate
{

	public MergeFailedEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, MergeFailedEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, MergeFailedEventArgs e) { }

}


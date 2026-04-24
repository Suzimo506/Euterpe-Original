namespace System.ComponentModel;

public sealed class ListChangedEventHandler : MulticastDelegate
{

	public ListChangedEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, ListChangedEventArgs e) { }

}


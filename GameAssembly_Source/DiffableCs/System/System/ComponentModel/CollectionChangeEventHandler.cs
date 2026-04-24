namespace System.ComponentModel;

public sealed class CollectionChangeEventHandler : MulticastDelegate
{

	public CollectionChangeEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, CollectionChangeEventArgs e) { }

}


namespace System.Collections.Specialized;

public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate
{

	public NotifyCollectionChangedEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, NotifyCollectionChangedEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}


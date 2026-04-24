namespace System.Xml.Serialization;

public sealed class UnreferencedObjectEventHandler : MulticastDelegate
{

	public UnreferencedObjectEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, UnreferencedObjectEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}


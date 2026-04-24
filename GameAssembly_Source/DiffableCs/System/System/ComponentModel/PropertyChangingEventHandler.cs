namespace System.ComponentModel;

public sealed class PropertyChangingEventHandler : MulticastDelegate
{

	public PropertyChangingEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, PropertyChangingEventArgs e) { }

}


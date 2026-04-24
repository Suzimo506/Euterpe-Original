namespace System.ComponentModel;

public sealed class PropertyChangedEventHandler : MulticastDelegate
{

	public PropertyChangedEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, PropertyChangedEventArgs e) { }

}


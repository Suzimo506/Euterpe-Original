namespace System.ComponentModel;

public sealed class AddingNewEventHandler : MulticastDelegate
{

	public AddingNewEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, AddingNewEventArgs e) { }

}


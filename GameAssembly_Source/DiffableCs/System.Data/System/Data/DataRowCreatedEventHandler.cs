namespace System.Data;

internal sealed class DataRowCreatedEventHandler : MulticastDelegate
{

	public DataRowCreatedEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, DataRow r) { }

}


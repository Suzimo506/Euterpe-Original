namespace System.Data;

public sealed class DataRowChangeEventHandler : MulticastDelegate
{

	public DataRowChangeEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, DataRowChangeEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, DataRowChangeEventArgs e) { }

}


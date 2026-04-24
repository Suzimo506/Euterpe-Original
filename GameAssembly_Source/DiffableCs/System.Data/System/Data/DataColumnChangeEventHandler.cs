namespace System.Data;

public sealed class DataColumnChangeEventHandler : MulticastDelegate
{

	public DataColumnChangeEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object sender, DataColumnChangeEventArgs e, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object sender, DataColumnChangeEventArgs e) { }

}


//Type is in global namespace

public sealed class RailEventCallBackFunction : MulticastDelegate
{

	public RailEventCallBackFunction(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(RAILEventID event_id, IntPtr data, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(RAILEventID event_id, IntPtr data) { }

}


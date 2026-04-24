//Type is in global namespace

public sealed class RailEventCallBackHandler : MulticastDelegate
{

	public RailEventCallBackHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(RAILEventID event_id, EventBase data, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(RAILEventID event_id, EventBase data) { }

}


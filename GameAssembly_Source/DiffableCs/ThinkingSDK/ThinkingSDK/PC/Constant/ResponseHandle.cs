namespace ThinkingSDK.PC.Constant;

public sealed class ResponseHandle : MulticastDelegate
{

	public ResponseHandle(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Dictionary<String, Object> result, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Dictionary<String, Object> result = null) { }

}


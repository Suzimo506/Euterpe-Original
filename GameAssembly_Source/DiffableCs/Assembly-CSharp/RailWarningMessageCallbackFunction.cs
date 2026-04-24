//Type is in global namespace

[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RailWarningMessageCallbackFunction : MulticastDelegate
{

	public RailWarningMessageCallbackFunction(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int level, string msg, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int level, string msg) { }

}


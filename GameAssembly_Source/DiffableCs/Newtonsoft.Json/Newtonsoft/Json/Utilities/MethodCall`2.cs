namespace Newtonsoft.Json.Utilities;

internal sealed class MethodCall : MulticastDelegate
{

	public MethodCall`2(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(T target, Object[] args, AsyncCallback callback, object object) { }

	public override TResult EndInvoke(IAsyncResult result) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override TResult Invoke(T target, Object[] args) { }

}


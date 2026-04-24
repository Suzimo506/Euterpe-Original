namespace NCalc;

public sealed class EvaluateFunctionHandler : MulticastDelegate
{

	public EvaluateFunctionHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(string name, FunctionArgs args, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(string name, FunctionArgs args) { }

}


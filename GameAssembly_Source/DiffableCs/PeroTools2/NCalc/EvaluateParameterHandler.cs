namespace NCalc;

public sealed class EvaluateParameterHandler : MulticastDelegate
{

	public EvaluateParameterHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(string name, ParameterArgs args, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(string name, ParameterArgs args) { }

}


namespace PeroTools2.Datas.Values;

public sealed class ValueDelegate : MulticastDelegate
{

	public ValueDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IValue value, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IValue value) { }

}


namespace PeroTools2.Datas.Values;

public sealed class BaseValueDelegate : MulticastDelegate
{

	public BaseValueDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IBaseValue value, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IBaseValue value) { }

}


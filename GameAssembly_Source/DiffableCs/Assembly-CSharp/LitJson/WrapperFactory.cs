namespace LitJson;

public sealed class WrapperFactory : MulticastDelegate
{

	public WrapperFactory(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public override IJsonWrapper EndInvoke(IAsyncResult result) { }

	public override IJsonWrapper Invoke() { }

}


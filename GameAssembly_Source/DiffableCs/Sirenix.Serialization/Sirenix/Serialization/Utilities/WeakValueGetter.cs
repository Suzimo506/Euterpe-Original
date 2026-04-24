namespace Sirenix.Serialization.Utilities;

internal sealed class WeakValueGetter : MulticastDelegate
{

	public WeakValueGetter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ref object instance, AsyncCallback callback, object object) { }

	public override object EndInvoke(ref object instance, IAsyncResult result) { }

	public override object Invoke(ref object instance) { }

}


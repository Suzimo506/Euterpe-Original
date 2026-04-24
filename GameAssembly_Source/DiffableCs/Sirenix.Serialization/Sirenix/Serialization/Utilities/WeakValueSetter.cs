namespace Sirenix.Serialization.Utilities;

internal sealed class WeakValueSetter : MulticastDelegate
{

	public WeakValueSetter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ref object instance, object value, AsyncCallback callback, object object) { }

	public override void EndInvoke(ref object instance, IAsyncResult result) { }

	public override void Invoke(ref object instance, object value) { }

}


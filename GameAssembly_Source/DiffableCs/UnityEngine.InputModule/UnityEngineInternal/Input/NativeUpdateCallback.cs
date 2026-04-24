namespace UnityEngineInternal.Input;

internal sealed class NativeUpdateCallback : MulticastDelegate
{

	public NativeUpdateCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}


//Type is in global namespace

[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RailCaptureVoiceCallback : MulticastDelegate
{

	public RailCaptureVoiceCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(EnumRailVoiceCaptureFormat fmt, bool is_last_package, IntPtr encoded_buffer, uint encoded_length, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(EnumRailVoiceCaptureFormat fmt, bool is_last_package, IntPtr encoded_buffer, uint encoded_length) { }

}


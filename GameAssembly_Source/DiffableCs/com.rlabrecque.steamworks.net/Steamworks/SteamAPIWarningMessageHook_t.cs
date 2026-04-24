namespace Steamworks;

[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate
{

	public SteamAPIWarningMessageHook_t(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int nSeverity, StringBuilder pchDebugText) { }

}


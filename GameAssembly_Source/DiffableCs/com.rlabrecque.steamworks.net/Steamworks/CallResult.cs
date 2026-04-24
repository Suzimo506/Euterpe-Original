namespace Steamworks;

public abstract class CallResult
{

	protected CallResult() { }

	internal abstract Type GetCallbackType() { }

	internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall) { }

	internal abstract void SetUnregistered() { }

}


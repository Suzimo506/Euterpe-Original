namespace Steamworks;

public abstract class Callback
{

	public abstract bool IsGameServer
	{
		 get { } //Length: 0
	}

	protected Callback() { }

	public abstract bool get_IsGameServer() { }

	internal abstract Type GetCallbackType() { }

	internal abstract void OnRunCallback(IntPtr pvParam) { }

	internal abstract void SetUnregistered() { }

}


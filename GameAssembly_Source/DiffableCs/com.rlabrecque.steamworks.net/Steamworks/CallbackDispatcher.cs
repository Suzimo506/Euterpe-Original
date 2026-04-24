namespace Steamworks;

public static class CallbackDispatcher
{
	private static Dictionary<Int32, List`1<Callback>> m_registeredCallbacks; //Field offset: 0x0
	private static Dictionary<Int32, List`1<Callback>> m_registeredGameServerCallbacks; //Field offset: 0x8
	private static Dictionary<UInt64, List`1<CallResult>> m_registeredCallResults; //Field offset: 0x10
	private static object m_sync; //Field offset: 0x18
	private static IntPtr m_pCallbackMsg; //Field offset: 0x20
	private static int m_initCount; //Field offset: 0x28

	public static bool IsInitialized
	{
		 get { } //Length: 90
	}

	private static CallbackDispatcher() { }

	public static void ExceptionHandler(Exception e) { }

	public static bool get_IsInitialized() { }

	internal static void Initialize() { }

	internal static void Register(Callback cb) { }

	internal static void Register(SteamAPICall_t asyncCall, CallResult cr) { }

	internal static void RunFrame(bool isGameServer) { }

	internal static void Shutdown() { }

	internal static void Unregister(Callback cb) { }

	internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr) { }

	private static void UnregisterAll() { }

}


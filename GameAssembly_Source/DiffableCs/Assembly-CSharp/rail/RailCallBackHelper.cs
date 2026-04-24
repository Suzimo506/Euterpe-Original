namespace rail;

public class RailCallBackHelper
{
	private static RailCallBackHelper instance_; //Field offset: 0x0
	private static readonly object locker_; //Field offset: 0x8
	private static Dictionary<RAILEventID, RailEventCallBackHandler> eventHandlers_; //Field offset: 0x10
	private static RailEventCallBackFunction delegate_; //Field offset: 0x18

	public static RailCallBackHelper Instance
	{
		 get { } //Length: 458
	}

	private static RailCallBackHelper() { }

	private RailCallBackHelper() { }

	public static RailCallBackHelper get_Instance() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void OnRailCallBack(RAILEventID event_id, IntPtr data) { }

	public void RegisterCallback(RAILEventID event_id, RailEventCallBackHandler handler) { }

	public void UnregisterAllCallback() { }

	public void UnregisterCallback(RAILEventID event_id, RailEventCallBackHandler handler) { }

	public void UnregisterCallback(RAILEventID event_id) { }

}


namespace rail;

public interface IRailFloatingWindow
{

	public RailResult AsyncCloseRailFloatingWindow(EnumRailWindowType window_type, string user_data) { }

	public RailResult AsyncShowDefaultGameStoreWindow(string user_data) { }

	public RailResult AsyncShowRailFloatingWindow(EnumRailWindowType window_type, string user_data) { }

	public RailResult AsyncShowStoreWindow(ulong id, RailStoreOptions options, string user_data) { }

	public bool IsFloatingWindowAvailable() { }

	public RailResult SetNotifyWindowEnable(EnumRailNotifyWindowType window_type, bool enable) { }

	public RailResult SetNotifyWindowPosition(EnumRailNotifyWindowType window_type, RailWindowLayout layout) { }

}


namespace rail;

public class IRailFloatingWindowImpl : RailObject, IRailFloatingWindow
{

	internal IRailFloatingWindowImpl(IntPtr cPtr) { }

	public override RailResult AsyncCloseRailFloatingWindow(EnumRailWindowType window_type, string user_data) { }

	public override RailResult AsyncShowDefaultGameStoreWindow(string user_data) { }

	public override RailResult AsyncShowRailFloatingWindow(EnumRailWindowType window_type, string user_data) { }

	public override RailResult AsyncShowStoreWindow(ulong id, RailStoreOptions options, string user_data) { }

	protected virtual void Finalize() { }

	public override bool IsFloatingWindowAvailable() { }

	public override RailResult SetNotifyWindowEnable(EnumRailNotifyWindowType window_type, bool enable) { }

	public override RailResult SetNotifyWindowPosition(EnumRailNotifyWindowType window_type, RailWindowLayout layout) { }

}


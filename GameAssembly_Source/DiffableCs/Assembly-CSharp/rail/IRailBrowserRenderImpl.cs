namespace rail;

public class IRailBrowserRenderImpl : RailObject, IRailBrowserRender, IRailComponent
{

	internal IRailBrowserRenderImpl(IntPtr cPtr) { }

	public override bool AddJavascriptEventListener(string event_name) { }

	public override void AllowNavigateNewPage(bool allow) { }

	public override void Close() { }

	public override void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos) { }

	public override void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param) { }

	public override bool ExecuteJavascript(string event_name, string event_value) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override bool GetCurrentUrl(out string url) { }

	public override void GoBack() { }

	public override void GoForward() { }

	public override void KeyChar(uint key_code, bool is_uinchar) { }

	public override void KeyDown(uint key_code) { }

	public override void KeyUp(uint key_code) { }

	public override void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos) { }

	public override void Release() { }

	public override bool ReloadWithUrl() { }

	public override bool ReloadWithUrl(string new_url) { }

	public override bool RemoveAllJavascriptEventListener() { }

	public override void SetBrowserActive(bool active) { }

	public override void SetFocus(bool has_focus) { }

	public override void StopLoad() { }

	public override void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height) { }

}


namespace rail;

public interface IRailBrowserRender : IRailComponent
{

	public bool AddJavascriptEventListener(string event_name) { }

	public void AllowNavigateNewPage(bool allow) { }

	public void Close() { }

	public void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos) { }

	public void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param) { }

	public bool ExecuteJavascript(string event_name, string event_value) { }

	public bool GetCurrentUrl(out string url) { }

	public void GoBack() { }

	public void GoForward() { }

	public void KeyChar(uint key_code, bool is_uinchar) { }

	public void KeyDown(uint key_code) { }

	public void KeyUp(uint key_code) { }

	public void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos) { }

	public bool ReloadWithUrl() { }

	public bool ReloadWithUrl(string new_url) { }

	public bool RemoveAllJavascriptEventListener() { }

	public void SetBrowserActive(bool active) { }

	public void SetFocus(bool has_focus) { }

	public void StopLoad() { }

	public void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height) { }

}


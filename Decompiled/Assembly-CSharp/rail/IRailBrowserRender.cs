using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000286")]
public interface IRailBrowserRender : IRailComponent
{
	[Token(Token = "0x6002CCE")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetCurrentUrl(out string url);

	[Token(Token = "0x6002CCF")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ReloadWithUrl(string new_url);

	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ReloadWithUrl();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD1")]
	void StopLoad();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD2")]
	bool AddJavascriptEventListener(string event_name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD3")]
	bool RemoveAllJavascriptEventListener();

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x0", Length = "0x0")]
	void AllowNavigateNewPage(bool allow);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD5")]
	void Close();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD6")]
	void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD7")]
	void SetBrowserActive(bool active);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CD8")]
	void GoBack();

	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x0", Length = "0x0")]
	void GoForward();

	[Token(Token = "0x6002CDA")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool ExecuteJavascript(string event_name, string event_value);

	[Token(Token = "0x6002CDB")]
	[Address(RVA = "0x0", Length = "0x0")]
	void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CDC")]
	void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CDD")]
	void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos);

	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetFocus(bool has_focus);

	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x0", Length = "0x0")]
	void KeyDown(uint key_code);

	[Token(Token = "0x6002CE0")]
	[Address(RVA = "0x0", Length = "0x0")]
	void KeyUp(uint key_code);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CE1")]
	void KeyChar(uint key_code, bool is_uinchar);
}

using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000232")]
public class IRailBrowserRenderImpl : RailObject, IRailBrowserRender, IRailComponent
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x6002767")]
	internal IRailBrowserRenderImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailBrowserRenderImpl()
	{
	}

	[Address(RVA = "0xD23060", Offset = "0xD21860", Length = "0x137")]
	[Token(Token = "0x6002769")]
	public virtual bool GetCurrentUrl(out string url)
	{
		url = null;
		return default(bool);
	}

	[Address(RVA = "0xD23510", Offset = "0xD21D10", Length = "0x65")]
	[Token(Token = "0x600276A")]
	public virtual bool ReloadWithUrl(string new_url)
	{
		return default(bool);
	}

	[Token(Token = "0x600276B")]
	[Address(RVA = "0xD234B0", Offset = "0xD21CB0", Length = "0x55")]
	public virtual bool ReloadWithUrl()
	{
		return default(bool);
	}

	[Address(RVA = "0xD236C0", Offset = "0xD21EC0", Length = "0x55")]
	[Token(Token = "0x600276C")]
	public virtual void StopLoad()
	{
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0xD22D20", Offset = "0xD21520", Length = "0x65")]
	public virtual bool AddJavascriptEventListener(string event_name)
	{
		return default(bool);
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0xD23580", Offset = "0xD21D80", Length = "0x55")]
	public virtual bool RemoveAllJavascriptEventListener()
	{
		return default(bool);
	}

	[Address(RVA = "0xD22D90", Offset = "0xD21590", Length = "0x66")]
	[Token(Token = "0x600276F")]
	public virtual void AllowNavigateNewPage(bool allow)
	{
	}

	[Address(RVA = "0xD22E00", Offset = "0xD21600", Length = "0x55")]
	[Token(Token = "0x6002770")]
	public virtual void Close()
	{
	}

	[Address(RVA = "0xD23720", Offset = "0xD21F20", Length = "0x89")]
	[Token(Token = "0x6002771")]
	public virtual void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height)
	{
	}

	[Address(RVA = "0xD235E0", Offset = "0xD21DE0", Length = "0x66")]
	[Token(Token = "0x6002772")]
	public virtual void SetBrowserActive(bool active)
	{
	}

	[Address(RVA = "0xD231A0", Offset = "0xD219A0", Length = "0x55")]
	[Token(Token = "0x6002773")]
	public virtual void GoBack()
	{
	}

	[Address(RVA = "0xD23200", Offset = "0xD21A00", Length = "0x55")]
	[Token(Token = "0x6002774")]
	public virtual void GoForward()
	{
	}

	[Address(RVA = "0xD22F80", Offset = "0xD21780", Length = "0x75")]
	[Token(Token = "0x6002775")]
	public virtual bool ExecuteJavascript(string event_name, string event_value)
	{
		return default(bool);
	}

	[Address(RVA = "0xD22EF0", Offset = "0xD216F0", Length = "0x89")]
	[Token(Token = "0x6002776")]
	public virtual void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param)
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0xD22E60", Offset = "0xD21660", Length = "0x89")]
	public virtual void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos)
	{
	}

	[Address(RVA = "0xD233C0", Offset = "0xD21BC0", Length = "0x89")]
	[Token(Token = "0x6002778")]
	public virtual void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos)
	{
	}

	[Address(RVA = "0xD23650", Offset = "0xD21E50", Length = "0x66")]
	[Token(Token = "0x6002779")]
	public virtual void SetFocus(bool has_focus)
	{
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0xD232E0", Offset = "0xD21AE0", Length = "0x63")]
	public virtual void KeyDown(uint key_code)
	{
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0xD23350", Offset = "0xD21B50", Length = "0x63")]
	public virtual void KeyUp(uint key_code)
	{
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0xD23260", Offset = "0xD21A60", Length = "0x75")]
	public virtual void KeyChar(uint key_code, bool is_uinchar)
	{
	}

	[Address(RVA = "0xD23000", Offset = "0xD21800", Length = "0x55")]
	[Token(Token = "0x600277D")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD23450", Offset = "0xD21C50", Length = "0x55")]
	[Token(Token = "0x600277E")]
	public virtual void Release()
	{
	}
}

namespace rail;

public class RailTextInputWindowOption
{
	public bool enable_multi_line_edit; //Field offset: 0x10
	public string description; //Field offset: 0x18
	public uint position_top; //Field offset: 0x20
	public uint position_left; //Field offset: 0x24
	public string caption_text; //Field offset: 0x28
	public bool show_password_input; //Field offset: 0x30
	public bool is_min_window; //Field offset: 0x31
	public string content_placeholder; //Field offset: 0x38
	public bool auto_cancel; //Field offset: 0x40

	public RailTextInputWindowOption() { }

}


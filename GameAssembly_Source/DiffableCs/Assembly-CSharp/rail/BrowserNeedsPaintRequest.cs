namespace rail;

public class BrowserNeedsPaintRequest : EventBase
{
	public uint bgra_width; //Field offset: 0x30
	public uint scroll_y_pos; //Field offset: 0x34
	public string bgra_data; //Field offset: 0x38
	public float page_scale_factor; //Field offset: 0x40
	public int offset_x; //Field offset: 0x44
	public uint scroll_x_pos; //Field offset: 0x48
	public uint bgra_height; //Field offset: 0x4C
	public int offset_y; //Field offset: 0x50

	public BrowserNeedsPaintRequest() { }

}


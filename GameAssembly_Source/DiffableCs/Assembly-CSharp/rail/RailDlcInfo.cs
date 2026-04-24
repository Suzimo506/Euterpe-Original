namespace rail;

public class RailDlcInfo
{
	public double original_price; //Field offset: 0x10
	public RailDlcID dlc_id; //Field offset: 0x18
	public string description; //Field offset: 0x20
	public double discount_price; //Field offset: 0x28
	public string version; //Field offset: 0x30
	public RailGameID game_id; //Field offset: 0x38
	public string name; //Field offset: 0x40

	public RailDlcInfo() { }

}


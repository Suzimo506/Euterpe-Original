namespace rail;

public class DlcOwnershipChanged : EventBase
{
	public RailDlcID dlc_id; //Field offset: 0x30
	public bool is_active; //Field offset: 0x38

	public DlcOwnershipChanged() { }

}


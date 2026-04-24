namespace rail;

public class DlcUninstallFinished : EventBase
{
	public RailDlcID dlc_id; //Field offset: 0x30
	public RailResult result; //Field offset: 0x38

	public DlcUninstallFinished() { }

}


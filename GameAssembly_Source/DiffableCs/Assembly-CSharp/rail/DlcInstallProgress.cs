namespace rail;

public class DlcInstallProgress : EventBase
{
	public RailDlcInstallProgress progress; //Field offset: 0x30
	public RailDlcID dlc_id; //Field offset: 0x38

	public DlcInstallProgress() { }

}


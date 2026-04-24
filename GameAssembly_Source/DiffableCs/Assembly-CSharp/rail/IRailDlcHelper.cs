namespace rail;

public interface IRailDlcHelper
{

	public RailResult AsyncCheckAllDlcsStateReady(string user_data) { }

	public bool AsyncInstallDlc(RailDlcID dlc_id, string user_data) { }

	public RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data) { }

	public bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data) { }

	public uint GetDlcCount() { }

	public bool GetDlcInfo(uint index, RailDlcInfo dlc_info) { }

	public bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path) { }

	public bool IsDlcInstalled(RailDlcID dlc_id) { }

	public bool IsOwnedDlc(RailDlcID dlc_id) { }

}


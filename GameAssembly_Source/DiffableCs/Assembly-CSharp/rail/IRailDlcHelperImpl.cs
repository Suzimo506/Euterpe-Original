namespace rail;

public class IRailDlcHelperImpl : RailObject, IRailDlcHelper
{

	internal IRailDlcHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncCheckAllDlcsStateReady(string user_data) { }

	public override bool AsyncInstallDlc(RailDlcID dlc_id, string user_data) { }

	public override RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data) { }

	public override bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data) { }

	protected virtual void Finalize() { }

	public override uint GetDlcCount() { }

	public override bool GetDlcInfo(uint index, RailDlcInfo dlc_info) { }

	public override bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path) { }

	public override bool IsDlcInstalled(RailDlcID dlc_id) { }

	public override bool IsOwnedDlc(RailDlcID dlc_id) { }

}


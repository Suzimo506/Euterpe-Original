namespace rail;

public class DlcRefundChanged : EventBase
{
	public RailDlcID dlc_id; //Field offset: 0x30
	public EnumRailGameRefundState refund_state; //Field offset: 0x38

	public DlcRefundChanged() { }

}


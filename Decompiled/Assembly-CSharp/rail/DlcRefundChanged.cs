using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AC")]
public class DlcRefundChanged : EventBase
{
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x30")]
	public RailDlcID dlc_id;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x38")]
	public EnumRailGameRefundState refund_state;

	[Token(Token = "0x6002D12")]
	[Address(RVA = "0xD1FDC0", Offset = "0xD1E5C0", Length = "0x64")]
	public DlcRefundChanged()
	{
	}
}

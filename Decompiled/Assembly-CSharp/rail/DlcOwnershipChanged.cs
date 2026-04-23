using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AB")]
public class DlcOwnershipChanged : EventBase
{
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x30")]
	public RailDlcID dlc_id;

	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x38")]
	public bool is_active;

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0xD1FD50", Offset = "0xD1E550", Length = "0x64")]
	public DlcOwnershipChanged()
	{
	}
}

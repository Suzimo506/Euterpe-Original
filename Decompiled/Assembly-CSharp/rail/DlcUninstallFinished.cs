using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AD")]
public class DlcUninstallFinished : EventBase
{
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x30")]
	public RailDlcID dlc_id;

	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x38")]
	public new RailResult result;

	[Address(RVA = "0xD1FE30", Offset = "0xD1E630", Length = "0x64")]
	[Token(Token = "0x6002D13")]
	public DlcUninstallFinished()
	{
	}
}

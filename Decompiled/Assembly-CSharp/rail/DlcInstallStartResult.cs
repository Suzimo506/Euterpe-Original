using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AA")]
public class DlcInstallStartResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400107E")]
	public RailDlcID dlc_id;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400107F")]
	public new RailResult result;

	[Address(RVA = "0xD1FC70", Offset = "0xD1E470", Length = "0x64")]
	[Token(Token = "0x6002D10")]
	public DlcInstallStartResult()
	{
	}
}

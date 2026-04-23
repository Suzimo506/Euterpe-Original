using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A7")]
public class DlcInstallFinished : EventBase
{
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x30")]
	public RailDlcID dlc_id;

	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x38")]
	public new RailResult result;

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0xD1FB70", Offset = "0xD1E370", Length = "0x64")]
	public DlcInstallFinished()
	{
	}
}

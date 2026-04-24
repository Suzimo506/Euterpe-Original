using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A8")]
public class DlcInstallProgress : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400107B")]
	public RailDlcInstallProgress progress;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400107C")]
	public RailDlcID dlc_id;

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0xD1FBE0", Offset = "0xD1E3E0", Length = "0x8C")]
	public DlcInstallProgress()
	{
	}
}

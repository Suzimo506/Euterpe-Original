using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002A9")]
public class DlcInstallStart : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400107D")]
	public RailDlcID dlc_id;

	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0xD1FCE0", Offset = "0xD1E4E0", Length = "0x64")]
	public DlcInstallStart()
	{
	}
}

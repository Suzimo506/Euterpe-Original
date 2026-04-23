using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000389")]
public class RailStreamFileOption
{
	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailStreamOpenFileType open_type;

	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0x14")]
	public bool unavaliabe_when_new_file_writing;

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailStreamFileOption()
	{
	}
}

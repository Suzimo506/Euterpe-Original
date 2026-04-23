using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000388")]
public class RailStreamFileInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014D7")]
	public ulong file_size;

	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x18")]
	public string filename;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002EF1")]
	public RailStreamFileInfo()
	{
	}
}

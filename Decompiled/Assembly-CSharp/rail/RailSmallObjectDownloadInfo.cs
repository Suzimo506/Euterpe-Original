using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200036E")]
public class RailSmallObjectDownloadInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014A5")]
	public uint index;

	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x14")]
	public RailResult result;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002EA8")]
	public RailSmallObjectDownloadInfo()
	{
	}
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000380")]
public class AsyncReadStreamFileResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014B8")]
	public uint try_read_length;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014B9")]
	public int offset;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014BA")]
	public string data;

	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x40")]
	public string filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EEB")]
	public AsyncReadStreamFileResult()
	{
	}
}

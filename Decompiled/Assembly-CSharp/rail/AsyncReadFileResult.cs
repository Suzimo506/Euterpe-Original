using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200037F")]
public class AsyncReadFileResult : EventBase
{
	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x30")]
	public uint try_read_length;

	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0x34")]
	public int offset;

	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x38")]
	public string data;

	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x40")]
	public string filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EEA")]
	public AsyncReadFileResult()
	{
	}
}

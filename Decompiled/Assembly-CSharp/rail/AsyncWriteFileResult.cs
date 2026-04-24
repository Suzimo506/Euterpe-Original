using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000382")]
public class AsyncWriteFileResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014BE")]
	public uint written_length;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014BF")]
	public int offset;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014C0")]
	public uint try_write_length;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014C1")]
	public string filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EED")]
	public AsyncWriteFileResult()
	{
	}
}

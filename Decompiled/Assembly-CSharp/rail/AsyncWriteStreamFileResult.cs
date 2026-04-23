using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000383")]
public class AsyncWriteStreamFileResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014C2")]
	public uint written_length;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014C3")]
	public int offset;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014C4")]
	public uint try_write_length;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014C5")]
	public string filename;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002EEE")]
	public AsyncWriteStreamFileResult()
	{
	}
}

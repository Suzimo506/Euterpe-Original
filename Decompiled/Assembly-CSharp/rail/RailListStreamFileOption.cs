using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000386")]
public class RailListStreamFileOption
{
	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x10")]
	public uint num_files;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40014CE")]
	public uint start_index;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002EEF")]
	public RailListStreamFileOption()
	{
	}
}

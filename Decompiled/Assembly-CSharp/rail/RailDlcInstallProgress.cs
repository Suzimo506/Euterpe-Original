using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002B0")]
public class RailDlcInstallProgress
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400108E")]
	public uint progress;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400108F")]
	public ulong finished_bytes;

	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x20")]
	public ulong total_bytes;

	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x28")]
	public uint speed;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002D16")]
	public RailDlcInstallProgress()
	{
	}
}

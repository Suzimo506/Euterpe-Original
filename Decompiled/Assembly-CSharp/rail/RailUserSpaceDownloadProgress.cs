using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B5")]
public class RailUserSpaceDownloadProgress
{
	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x10")]
	public uint progress;

	[Token(Token = "0x400156C")]
	[FieldOffset(Offset = "0x18")]
	public ulong total;

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x20")]
	public uint speed;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400156E")]
	public SpaceWorkID id;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400156F")]
	public ulong finidshed;

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x2721610", Offset = "0x271FE10", Length = "0x9D")]
	public RailUserSpaceDownloadProgress()
	{
	}
}

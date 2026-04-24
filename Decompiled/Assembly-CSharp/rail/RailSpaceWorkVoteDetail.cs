using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B4")]
public class RailSpaceWorkVoteDetail
{
	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x10")]
	public EnumRailSpaceWorkRateValue vote_value;

	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x14")]
	public uint voted_players;

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RailSpaceWorkVoteDetail()
	{
	}
}

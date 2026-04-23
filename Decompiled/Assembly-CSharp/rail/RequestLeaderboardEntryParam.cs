using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000328")]
public class RequestLeaderboardEntryParam
{
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x10")]
	public int range_end;

	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x14")]
	public int range_start;

	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x18")]
	public LeaderboardType type;

	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x1C")]
	public bool user_coordinate;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002E1C")]
	public RequestLeaderboardEntryParam()
	{
	}
}

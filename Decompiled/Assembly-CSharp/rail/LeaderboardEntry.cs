using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000320")]
public class LeaderboardEntry
{
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x10")]
	public RailID player_id;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001274")]
	public LeaderboardData data;

	[Address(RVA = "0x37E350", Offset = "0x37CB50", Length = "0xD9")]
	[Token(Token = "0x6002E17")]
	public LeaderboardEntry()
	{
	}
}

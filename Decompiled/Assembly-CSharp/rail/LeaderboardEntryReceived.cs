using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000321")]
public class LeaderboardEntryReceived : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001275")]
	public string leaderboard_name;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E18")]
	public LeaderboardEntryReceived()
	{
	}
}

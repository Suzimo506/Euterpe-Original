using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200031D")]
public class LeaderboardCreated : EventBase
{
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0x30")]
	public string leaderboard_name;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E15")]
	public LeaderboardCreated()
	{
	}
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000323")]
public class LeaderboardReceived : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001277")]
	public string leaderboard_name;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001278")]
	public bool does_exist;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E1A")]
	public LeaderboardReceived()
	{
	}
}

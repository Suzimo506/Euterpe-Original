using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200031C")]
public class LeaderboardAttachSpaceWork : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001267")]
	public string leaderboard_name;

	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0x38")]
	public SpaceWorkID spacework_id;

	[Address(RVA = "0x37E270", Offset = "0x37CA70", Length = "0x64")]
	[Token(Token = "0x6002E14")]
	public LeaderboardAttachSpaceWork()
	{
	}
}

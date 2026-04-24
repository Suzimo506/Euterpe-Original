using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000326")]
public class LeaderboardUploaded : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001283")]
	public int old_rank;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001284")]
	public string leaderboard_name;

	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x40")]
	public double score;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001286")]
	public bool better_score;

	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x4C")]
	public int new_rank;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002E1B")]
	public LeaderboardUploaded()
	{
	}
}

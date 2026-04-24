using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200031E")]
public class LeaderboardData
{
	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x10")]
	public string additional_infomation;

	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x18")]
	public double score;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400126C")]
	public int rank;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400126D")]
	public SpaceWorkID spacework_id;

	[Address(RVA = "0x37E2E0", Offset = "0x37CAE0", Length = "0x64")]
	[Token(Token = "0x6002E16")]
	public LeaderboardData()
	{
	}
}

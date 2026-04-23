using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200031A")]
public interface IRailLeaderboardEntries : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E0C")]
	RailID GetRailID();

	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetLeaderboardName();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E0E")]
	RailResult AsyncRequestLeaderboardEntries(RailID player, RequestLeaderboardEntryParam param, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E0F")]
	RequestLeaderboardEntryParam GetEntriesParam();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E10")]
	int GetEntriesCount();

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetLeaderboardEntry(int index, LeaderboardEntry leaderboard_entry);
}

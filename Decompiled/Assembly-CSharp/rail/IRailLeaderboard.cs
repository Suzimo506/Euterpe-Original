using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000319")]
public interface IRailLeaderboard : IRailComponent
{
	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x0", Length = "0x0")]
	string GetLeaderboardName();

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x0", Length = "0x0")]
	int GetTotalEntriesCount();

	[Token(Token = "0x6002E05")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetLeaderboard(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E06")]
	RailResult GetLeaderboardParameters(LeaderboardParameters param);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E07")]
	IRailLeaderboardEntries CreateLeaderboardEntries();

	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncUploadLeaderboard(UploadLeaderboardParam update_param, string user_data);

	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetLeaderboardSortType(out int sort_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E0A")]
	RailResult GetLeaderboardDisplayType(out int display_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E0B")]
	RailResult AsyncAttachSpaceWork(SpaceWorkID spacework_id, string user_data);
}

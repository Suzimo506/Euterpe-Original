using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200031B")]
public interface IRailLeaderboardHelper
{
	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailLeaderboard OpenLeaderboard(string leaderboard_name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E13")]
	IRailLeaderboard AsyncCreateLeaderboard(string leaderboard_name, LeaderboardSortType sort_type, LeaderboardDisplayType display_type, string user_data, out RailResult result);
}

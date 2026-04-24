using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002D9")]
public interface IRailGame
{
	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailGameID GetGameID();

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult ReportGameContentDamaged(EnumRailGameContentDamageFlag flag);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D68")]
	RailResult GetGameInstallPath(out string app_path);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D69")]
	RailResult AsyncQuerySubscribeWishPlayState(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D6A")]
	RailResult GetPlayerSelectedLanguageCode(out string language_code);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D6B")]
	RailResult GetGameSupportedLanguageCodes(List<string> language_codes);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D6C")]
	RailResult SetGameState(EnumRailGamePlayingState game_state);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D6D")]
	RailResult GetGameState(out EnumRailGamePlayingState game_state);

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult RegisterGameDefineGamePlayingState(List<RailGameDefineGamePlayingState> game_playing_states);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D6F")]
	RailResult SetGameDefineGamePlayingState(uint game_playing_state);

	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGameDefineGamePlayingState(out uint game_playing_state);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D71")]
	RailResult GetBranchBuildNumber(out string build_number);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D72")]
	RailResult GetCurrentBranchInfo(RailBranchInfo branch_info);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D73")]
	RailResult StartGameTimeCounting(string counting_key);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D74")]
	RailResult EndGameTimeCounting(string counting_key);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D75")]
	RailID GetGamePurchasePlayerRailID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D76")]
	uint GetGameEarliestPurchaseTime();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D77")]
	uint GetTimeCountSinceGameActivated();

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetTimeCountSinceLastMouseMoved();
}

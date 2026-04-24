namespace rail;

public interface IRailGame
{

	public RailResult AsyncQuerySubscribeWishPlayState(string user_data) { }

	public RailResult EndGameTimeCounting(string counting_key) { }

	public RailResult GetBranchBuildNumber(out string build_number) { }

	public RailResult GetCurrentBranchInfo(RailBranchInfo branch_info) { }

	public RailResult GetGameDefineGamePlayingState(out uint game_playing_state) { }

	public uint GetGameEarliestPurchaseTime() { }

	public RailGameID GetGameID() { }

	public RailResult GetGameInstallPath(out string app_path) { }

	public RailID GetGamePurchasePlayerRailID() { }

	public RailResult GetGameState(out EnumRailGamePlayingState game_state) { }

	public RailResult GetGameSupportedLanguageCodes(List<String> language_codes) { }

	public RailResult GetPlayerSelectedLanguageCode(out string language_code) { }

	public uint GetTimeCountSinceGameActivated() { }

	public uint GetTimeCountSinceLastMouseMoved() { }

	public RailResult RegisterGameDefineGamePlayingState(List<RailGameDefineGamePlayingState> game_playing_states) { }

	public RailResult ReportGameContentDamaged(EnumRailGameContentDamageFlag flag) { }

	public RailResult SetGameDefineGamePlayingState(uint game_playing_state) { }

	public RailResult SetGameState(EnumRailGamePlayingState game_state) { }

	public RailResult StartGameTimeCounting(string counting_key) { }

}


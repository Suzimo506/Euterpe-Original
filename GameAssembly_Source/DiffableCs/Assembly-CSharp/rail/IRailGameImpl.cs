namespace rail;

public class IRailGameImpl : RailObject, IRailGame
{

	internal IRailGameImpl(IntPtr cPtr) { }

	public override RailResult AsyncQuerySubscribeWishPlayState(string user_data) { }

	public override RailResult EndGameTimeCounting(string counting_key) { }

	protected virtual void Finalize() { }

	public override RailResult GetBranchBuildNumber(out string build_number) { }

	public override RailResult GetCurrentBranchInfo(RailBranchInfo branch_info) { }

	public override RailResult GetGameDefineGamePlayingState(out uint game_playing_state) { }

	public override uint GetGameEarliestPurchaseTime() { }

	public override RailGameID GetGameID() { }

	public override RailResult GetGameInstallPath(out string app_path) { }

	public override RailID GetGamePurchasePlayerRailID() { }

	public override RailResult GetGameState(out EnumRailGamePlayingState game_state) { }

	public override RailResult GetGameSupportedLanguageCodes(List<String> language_codes) { }

	public override RailResult GetPlayerSelectedLanguageCode(out string language_code) { }

	public override uint GetTimeCountSinceGameActivated() { }

	public override uint GetTimeCountSinceLastMouseMoved() { }

	public override RailResult RegisterGameDefineGamePlayingState(List<RailGameDefineGamePlayingState> game_playing_states) { }

	public override RailResult ReportGameContentDamaged(EnumRailGameContentDamageFlag flag) { }

	public override RailResult SetGameDefineGamePlayingState(uint game_playing_state) { }

	public override RailResult SetGameState(EnumRailGamePlayingState game_state) { }

	public override RailResult StartGameTimeCounting(string counting_key) { }

}


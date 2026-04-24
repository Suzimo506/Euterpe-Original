namespace rail;

public class IRailGameServerImpl : RailObject, IRailGameServer, IRailComponent
{

	internal IRailGameServerImpl(IntPtr cPtr) { }

	public override void AbandonGameServerSessionTicket(RailSessionTicket session_ticket) { }

	public override RailResult AsyncAcquireGameServerSessionTicket(string user_data) { }

	public override RailResult AsyncGetAllMetadata(string user_data) { }

	public override RailResult AsyncGetMetadata(List<String> keys, string user_data) { }

	public override RailResult AsyncSetMetadata(List<RailKeyValue> key_values, string user_data) { }

	public override RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data) { }

	public override bool ClearAllMetadata() { }

	public override RailResult CloseGameServer() { }

	public override RailResult EnableTeamVoice(bool enable) { }

	protected virtual void Finalize() { }

	public override uint GetBotPlayers() { }

	public override ulong GetComponentVersion() { }

	public override uint GetCurrentPlayers() { }

	public override RailResult GetFriendsInGameServer(List<RailID> friend_ids) { }

	public override bool GetGameServerDescription(out string game_server_description) { }

	public override RailResult GetGameServerFullName(out string full_name) { }

	public override RailResult GetGameServerName(out string name) { }

	public override RailID GetGameServerRailID() { }

	public override bool GetGameServerTags(out string game_server_tags) { }

	public override bool GetGameServerVersion(out string version) { }

	public override bool GetHost(out string game_server_host) { }

	public override bool GetIsFriendOnly() { }

	public override bool GetMapName(out string game_server_map) { }

	public override uint GetMaxPlayers() { }

	public override RailResult GetMetadata(string key, out string value) { }

	public override bool GetMods(List<String> server_mods) { }

	public override RailID GetOwnerRailID() { }

	public override bool GetPasswordProtect() { }

	public override bool GetServerInfo(out string server_info) { }

	public override bool GetSpectatorHost(out string spectator_host) { }

	public override bool IsUserInGameServer(RailID user_rail_id) { }

	public override RailResult RegisterToGameServerList() { }

	public override void Release() { }

	public override void RemoveAllPlayers() { }

	public override RailResult ReportPlayerJoinGameServer(List<GameServerPlayerInfo> player_infos) { }

	public override RailResult ReportPlayerQuitGameServer(List<GameServerPlayerInfo> player_infos) { }

	public override bool SetBotPlayers(uint bot_player_count) { }

	public override bool SetGameServerDescription(string game_server_description) { }

	public override bool SetGameServerTags(string game_server_tags) { }

	public override bool SetGameServerVersion(string version) { }

	public override bool SetHost(string game_server_host) { }

	public override bool SetIsFriendOnly(bool is_friend_only) { }

	public override bool SetMapName(string game_server_map) { }

	public override bool SetMaxPlayers(uint max_player_count) { }

	public override RailResult SetMetadata(string key, string value) { }

	public override bool SetMods(List<String> server_mods) { }

	public override bool SetPasswordProtect(bool has_password) { }

	public override bool SetServerInfo(string server_info) { }

	public override bool SetSpectatorHost(string spectator_host) { }

	public override void TerminateSessionOfPlayer(RailID player_rail_id) { }

	public override RailResult UnregisterFromGameServerList() { }

	public override RailResult UpdateGameServerPlayerList(List<GameServerPlayerInfo> player_infos) { }

}


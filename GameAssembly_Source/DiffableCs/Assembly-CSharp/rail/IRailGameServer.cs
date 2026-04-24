namespace rail;

public interface IRailGameServer : IRailComponent
{

	public void AbandonGameServerSessionTicket(RailSessionTicket session_ticket) { }

	public RailResult AsyncAcquireGameServerSessionTicket(string user_data) { }

	public RailResult AsyncGetAllMetadata(string user_data) { }

	public RailResult AsyncGetMetadata(List<String> keys, string user_data) { }

	public RailResult AsyncSetMetadata(List<RailKeyValue> key_values, string user_data) { }

	public RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data) { }

	public bool ClearAllMetadata() { }

	public RailResult CloseGameServer() { }

	public RailResult EnableTeamVoice(bool enable) { }

	public uint GetBotPlayers() { }

	public uint GetCurrentPlayers() { }

	public RailResult GetFriendsInGameServer(List<RailID> friend_ids) { }

	public bool GetGameServerDescription(out string game_server_description) { }

	public RailResult GetGameServerFullName(out string full_name) { }

	public RailResult GetGameServerName(out string name) { }

	public RailID GetGameServerRailID() { }

	public bool GetGameServerTags(out string game_server_tags) { }

	public bool GetGameServerVersion(out string version) { }

	public bool GetHost(out string game_server_host) { }

	public bool GetIsFriendOnly() { }

	public bool GetMapName(out string game_server_map) { }

	public uint GetMaxPlayers() { }

	public RailResult GetMetadata(string key, out string value) { }

	public bool GetMods(List<String> server_mods) { }

	public RailID GetOwnerRailID() { }

	public bool GetPasswordProtect() { }

	public bool GetServerInfo(out string server_info) { }

	public bool GetSpectatorHost(out string spectator_host) { }

	public bool IsUserInGameServer(RailID user_rail_id) { }

	public RailResult RegisterToGameServerList() { }

	public void RemoveAllPlayers() { }

	public RailResult ReportPlayerJoinGameServer(List<GameServerPlayerInfo> player_infos) { }

	public RailResult ReportPlayerQuitGameServer(List<GameServerPlayerInfo> player_infos) { }

	public bool SetBotPlayers(uint bot_player_count) { }

	public bool SetGameServerDescription(string game_server_description) { }

	public bool SetGameServerTags(string game_server_tags) { }

	public bool SetGameServerVersion(string version) { }

	public bool SetHost(string game_server_host) { }

	public bool SetIsFriendOnly(bool is_friend_only) { }

	public bool SetMapName(string game_server_map) { }

	public bool SetMaxPlayers(uint max_player_count) { }

	public RailResult SetMetadata(string key, string value) { }

	public bool SetMods(List<String> server_mods) { }

	public bool SetPasswordProtect(bool has_password) { }

	public bool SetServerInfo(string server_info) { }

	public bool SetSpectatorHost(string spectator_host) { }

	public void TerminateSessionOfPlayer(RailID player_rail_id) { }

	public RailResult UnregisterFromGameServerList() { }

	public RailResult UpdateGameServerPlayerList(List<GameServerPlayerInfo> player_infos) { }

}


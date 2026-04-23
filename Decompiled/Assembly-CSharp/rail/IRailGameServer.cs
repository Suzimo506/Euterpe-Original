using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002DF")]
public interface IRailGameServer : IRailComponent
{
	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailID GetGameServerRailID();

	[Token(Token = "0x6002D7D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGameServerName(out string name);

	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetGameServerFullName(out string full_name);

	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailID GetOwnerRailID();

	[Token(Token = "0x6002D80")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetHost(string game_server_host);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D81")]
	bool GetHost(out string game_server_host);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D82")]
	bool SetMapName(string game_server_map);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D83")]
	bool GetMapName(out string game_server_map);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D84")]
	bool SetPasswordProtect(bool has_password);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D85")]
	bool GetPasswordProtect();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D86")]
	bool SetMaxPlayers(uint max_player_count);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D87")]
	uint GetMaxPlayers();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D88")]
	bool SetBotPlayers(uint bot_player_count);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D89")]
	uint GetBotPlayers();

	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetGameServerDescription(string game_server_description);

	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetGameServerDescription(out string game_server_description);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D8C")]
	bool SetGameServerTags(string game_server_tags);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D8D")]
	bool GetGameServerTags(out string game_server_tags);

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetMods(List<string> server_mods);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D8F")]
	bool GetMods(List<string> server_mods);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D90")]
	bool SetSpectatorHost(string spectator_host);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D91")]
	bool GetSpectatorHost(out string spectator_host);

	[Token(Token = "0x6002D92")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetGameServerVersion(string version);

	[Token(Token = "0x6002D93")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetGameServerVersion(out string version);

	[Token(Token = "0x6002D94")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetIsFriendOnly(bool is_friend_only);

	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetIsFriendOnly();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D96")]
	bool ClearAllMetadata();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D97")]
	RailResult GetMetadata(string key, out string value);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D98")]
	RailResult SetMetadata(string key, string value);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D99")]
	RailResult AsyncSetMetadata(List<RailKeyValue> key_values, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D9A")]
	RailResult AsyncGetMetadata(List<string> keys, string user_data);

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetAllMetadata(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D9C")]
	RailResult AsyncAcquireGameServerSessionTicket(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D9D")]
	RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data);

	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x0", Length = "0x0")]
	void TerminateSessionOfPlayer(RailID player_rail_id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D9F")]
	void AbandonGameServerSessionTicket(RailSessionTicket session_ticket);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DA0")]
	RailResult ReportPlayerJoinGameServer(List<GameServerPlayerInfo> player_infos);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DA1")]
	RailResult ReportPlayerQuitGameServer(List<GameServerPlayerInfo> player_infos);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DA2")]
	RailResult UpdateGameServerPlayerList(List<GameServerPlayerInfo> player_infos);

	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetCurrentPlayers();

	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x0", Length = "0x0")]
	void RemoveAllPlayers();

	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult RegisterToGameServerList();

	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult UnregisterFromGameServerList();

	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult CloseGameServer();

	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetFriendsInGameServer(List<RailID> friend_ids);

	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsUserInGameServer(RailID user_rail_id);

	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool SetServerInfo(string server_info);

	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool GetServerInfo(out string server_info);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DAC")]
	RailResult EnableTeamVoice(bool enable);
}

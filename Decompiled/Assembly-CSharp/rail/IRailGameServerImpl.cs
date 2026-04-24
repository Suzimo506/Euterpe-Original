using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000239")]
public class IRailGameServerImpl : RailObject, IRailGameServer, IRailComponent
{
	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailGameServerImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailGameServerImpl()
	{
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0xD298E0", Offset = "0xD280E0", Length = "0x8C")]
	public virtual RailID GetGameServerRailID()
	{
		return null;
	}

	[Address(RVA = "0xD297A0", Offset = "0xD27FA0", Length = "0x131")]
	[Token(Token = "0x60027E8")]
	public virtual RailResult GetGameServerName(out string name)
	{
		name = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD29660", Offset = "0xD27E60", Length = "0x131")]
	[Token(Token = "0x60027E9")]
	public virtual RailResult GetGameServerFullName(out string full_name)
	{
		full_name = null;
		return default(RailResult);
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0xD2A1B0", Offset = "0xD289B0", Length = "0x8C")]
	public virtual RailID GetOwnerRailID()
	{
		return null;
	}

	[Address(RVA = "0xD2ABE0", Offset = "0xD293E0", Length = "0x65")]
	[Token(Token = "0x60027EB")]
	public virtual bool SetHost(string game_server_host)
	{
		return default(bool);
	}

	[Address(RVA = "0xD29BF0", Offset = "0xD283F0", Length = "0x137")]
	[Token(Token = "0x60027EC")]
	public virtual bool GetHost(out string game_server_host)
	{
		game_server_host = null;
		return default(bool);
	}

	[Address(RVA = "0xD2ACC0", Offset = "0xD294C0", Length = "0x65")]
	[Token(Token = "0x60027ED")]
	public virtual bool SetMapName(string game_server_map)
	{
		return default(bool);
	}

	[Address(RVA = "0xD29D90", Offset = "0xD28590", Length = "0x137")]
	[Token(Token = "0x60027EE")]
	public virtual bool GetMapName(out string game_server_map)
	{
		game_server_map = null;
		return default(bool);
	}

	[Token(Token = "0x60027EF")]
	[Address(RVA = "0xD2AF50", Offset = "0xD29750", Length = "0x66")]
	public virtual bool SetPasswordProtect(bool has_password)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F0")]
	[Address(RVA = "0xD2A240", Offset = "0xD28A40", Length = "0x55")]
	public virtual bool GetPasswordProtect()
	{
		return default(bool);
	}

	[Token(Token = "0x60027F1")]
	[Address(RVA = "0xD2AD30", Offset = "0xD29530", Length = "0x63")]
	public virtual bool SetMaxPlayers(uint max_player_count)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0xD29ED0", Offset = "0xD286D0", Length = "0x55")]
	public virtual uint GetMaxPlayers()
	{
		return default(uint);
	}

	[Address(RVA = "0xD2AA20", Offset = "0xD29220", Length = "0x63")]
	[Token(Token = "0x60027F3")]
	public virtual bool SetBotPlayers(uint bot_player_count)
	{
		return default(bool);
	}

	[Address(RVA = "0xD292D0", Offset = "0xD27AD0", Length = "0x55")]
	[Token(Token = "0x60027F4")]
	public virtual uint GetBotPlayers()
	{
		return default(uint);
	}

	[Token(Token = "0x60027F5")]
	[Address(RVA = "0xD2AA90", Offset = "0xD29290", Length = "0x65")]
	public virtual bool SetGameServerDescription(string game_server_description)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F6")]
	[Address(RVA = "0xD29520", Offset = "0xD27D20", Length = "0x137")]
	public virtual bool GetGameServerDescription(out string game_server_description)
	{
		game_server_description = null;
		return default(bool);
	}

	[Token(Token = "0x60027F7")]
	[Address(RVA = "0xD2AB00", Offset = "0xD29300", Length = "0x65")]
	public virtual bool SetGameServerTags(string game_server_tags)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F8")]
	[Address(RVA = "0xD29970", Offset = "0xD28170", Length = "0x137")]
	public virtual bool GetGameServerTags(out string game_server_tags)
	{
		game_server_tags = null;
		return default(bool);
	}

	[Token(Token = "0x60027F9")]
	[Address(RVA = "0xD2AE20", Offset = "0xD29620", Length = "0x129")]
	public virtual bool SetMods(List<string> server_mods)
	{
		return default(bool);
	}

	[Token(Token = "0x60027FA")]
	[Address(RVA = "0xD2A070", Offset = "0xD28870", Length = "0x132")]
	public virtual bool GetMods(List<string> server_mods)
	{
		return default(bool);
	}

	[Token(Token = "0x60027FB")]
	[Address(RVA = "0xD2B030", Offset = "0xD29830", Length = "0x65")]
	public virtual bool SetSpectatorHost(string spectator_host)
	{
		return default(bool);
	}

	[Token(Token = "0x60027FC")]
	[Address(RVA = "0xD2A3E0", Offset = "0xD28BE0", Length = "0x137")]
	public virtual bool GetSpectatorHost(out string spectator_host)
	{
		spectator_host = null;
		return default(bool);
	}

	[Token(Token = "0x60027FD")]
	[Address(RVA = "0xD2AB70", Offset = "0xD29370", Length = "0x65")]
	public virtual bool SetGameServerVersion(string version)
	{
		return default(bool);
	}

	[Token(Token = "0x60027FE")]
	[Address(RVA = "0xD29AB0", Offset = "0xD282B0", Length = "0x137")]
	public virtual bool GetGameServerVersion(out string version)
	{
		version = null;
		return default(bool);
	}

	[Token(Token = "0x60027FF")]
	[Address(RVA = "0xD2AC50", Offset = "0xD29450", Length = "0x66")]
	public virtual bool SetIsFriendOnly(bool is_friend_only)
	{
		return default(bool);
	}

	[Address(RVA = "0xD29D30", Offset = "0xD28530", Length = "0x55")]
	[Token(Token = "0x6002800")]
	public virtual bool GetIsFriendOnly()
	{
		return default(bool);
	}

	[Token(Token = "0x6002801")]
	[Address(RVA = "0xD291A0", Offset = "0xD279A0", Length = "0x55")]
	public virtual bool ClearAllMetadata()
	{
		return default(bool);
	}

	[Token(Token = "0x6002802")]
	[Address(RVA = "0xD29F30", Offset = "0xD28730", Length = "0x135")]
	public virtual RailResult GetMetadata(string key, out string value)
	{
		value = null;
		return default(RailResult);
	}

	[Token(Token = "0x6002803")]
	[Address(RVA = "0xD2ADA0", Offset = "0xD295A0", Length = "0x75")]
	public virtual RailResult SetMetadata(string key, string value)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28E90", Offset = "0xD27690", Length = "0x128")]
	[Token(Token = "0x6002804")]
	public virtual RailResult AsyncSetMetadata(List<RailKeyValue> key_values, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28D60", Offset = "0xD27560", Length = "0x128")]
	[Token(Token = "0x6002805")]
	public virtual RailResult AsyncGetMetadata(List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28CF0", Offset = "0xD274F0", Length = "0x65")]
	[Token(Token = "0x6002806")]
	public virtual RailResult AsyncGetAllMetadata(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28C80", Offset = "0xD27480", Length = "0x65")]
	[Token(Token = "0x6002807")]
	public virtual RailResult AsyncAcquireGameServerSessionTicket(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28FC0", Offset = "0xD277C0", Length = "0x1DD")]
	[Token(Token = "0x6002808")]
	public virtual RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B0A0", Offset = "0xD298A0", Length = "0x16A")]
	[Token(Token = "0x6002809")]
	public virtual void TerminateSessionOfPlayer(RailID player_rail_id)
	{
	}

	[Address(RVA = "0xD28B60", Offset = "0xD27360", Length = "0x117")]
	[Token(Token = "0x600280A")]
	public virtual void AbandonGameServerSessionTicket(RailSessionTicket session_ticket)
	{
	}

	[Address(RVA = "0xD2A7C0", Offset = "0xD28FC0", Length = "0x124")]
	[Token(Token = "0x600280B")]
	public virtual RailResult ReportPlayerJoinGameServer(List<GameServerPlayerInfo> player_infos)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2A8F0", Offset = "0xD290F0", Length = "0x124")]
	[Token(Token = "0x600280C")]
	public virtual RailResult ReportPlayerQuitGameServer(List<GameServerPlayerInfo> player_infos)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B270", Offset = "0xD29A70", Length = "0x124")]
	[Token(Token = "0x600280D")]
	public virtual RailResult UpdateGameServerPlayerList(List<GameServerPlayerInfo> player_infos)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD29390", Offset = "0xD27B90", Length = "0x55")]
	[Token(Token = "0x600280E")]
	public virtual uint GetCurrentPlayers()
	{
		return default(uint);
	}

	[Address(RVA = "0xD2A760", Offset = "0xD28F60", Length = "0x55")]
	[Token(Token = "0x600280F")]
	public virtual void RemoveAllPlayers()
	{
	}

	[Token(Token = "0x6002810")]
	[Address(RVA = "0xD2A6A0", Offset = "0xD28EA0", Length = "0x55")]
	public virtual RailResult RegisterToGameServerList()
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2B210", Offset = "0xD29A10", Length = "0x55")]
	[Token(Token = "0x6002811")]
	public virtual RailResult UnregisterFromGameServerList()
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD29200", Offset = "0xD27A00", Length = "0x55")]
	[Token(Token = "0x6002812")]
	public virtual RailResult CloseGameServer()
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD293F0", Offset = "0xD27BF0", Length = "0x12E")]
	[Token(Token = "0x6002813")]
	public virtual RailResult GetFriendsInGameServer(List<RailID> friend_ids)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2A520", Offset = "0xD28D20", Length = "0x17C")]
	[Token(Token = "0x6002814")]
	public virtual bool IsUserInGameServer(RailID user_rail_id)
	{
		return default(bool);
	}

	[Address(RVA = "0xD2AFC0", Offset = "0xD297C0", Length = "0x65")]
	[Token(Token = "0x6002815")]
	public virtual bool SetServerInfo(string server_info)
	{
		return default(bool);
	}

	[Address(RVA = "0xD2A2A0", Offset = "0xD28AA0", Length = "0x137")]
	[Token(Token = "0x6002816")]
	public virtual bool GetServerInfo(out string server_info)
	{
		server_info = null;
		return default(bool);
	}

	[Address(RVA = "0xD29260", Offset = "0xD27A60", Length = "0x66")]
	[Token(Token = "0x6002817")]
	public virtual RailResult EnableTeamVoice(bool enable)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0xD29330", Offset = "0xD27B30", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0xD2A700", Offset = "0xD28F00", Length = "0x55")]
	[Token(Token = "0x6002819")]
	public virtual void Release()
	{
	}
}

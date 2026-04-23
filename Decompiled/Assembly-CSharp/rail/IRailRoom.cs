using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000341")]
public interface IRailRoom : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E51")]
	RailResult AsyncJoinRoom(string password, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E52")]
	ulong GetRoomID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E53")]
	RailResult GetRoomName(out string name);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E54")]
	RailID GetOwnerID();

	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool HasPassword();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E56")]
	EnumRoomType GetRoomType();

	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetMembers();

	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailID GetMemberByIndex(uint index);

	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetMemberNameByIndex(uint index, out string name);

	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetMaxMembers();

	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Leave();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E5C")]
	RailResult AsyncSetNewRoomOwner(RailID new_owner_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E5D")]
	RailResult AsyncGetRoomMembers(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E5E")]
	RailResult AsyncGetAllRoomData(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E5F")]
	RailResult AsyncKickOffMember(RailID member_id, string user_data);

	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSetRoomTag(string room_tag, string user_data);

	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetRoomTag(string user_data);

	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSetRoomMetadata(List<RailKeyValue> key_values, string user_data);

	[Token(Token = "0x6002E63")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetRoomMetadata(List<string> keys, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E64")]
	RailResult AsyncClearRoomMetadata(List<string> keys, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E65")]
	RailResult AsyncSetMemberMetadata(RailID member_id, List<RailKeyValue> key_values, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E66")]
	RailResult AsyncGetMemberMetadata(RailID member_id, List<string> keys, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E67")]
	RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len, uint message_type);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E68")]
	RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E69")]
	RailResult SetGameServerID(RailID game_server_rail_id);

	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailID GetGameServerID();

	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetRoomJoinable(bool is_joinable);

	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsRoomJoinable();

	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetFriendsInRoom(List<RailID> friend_ids);

	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x0", Length = "0x0")]
	bool IsUserInRoom(RailID user_rail_id);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E6F")]
	RailResult EnableTeamVoice(bool enable);

	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSetRoomType(EnumRoomType room_type, string user_data);

	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncSetRoomMaxMember(uint max_member, string user_data);
}

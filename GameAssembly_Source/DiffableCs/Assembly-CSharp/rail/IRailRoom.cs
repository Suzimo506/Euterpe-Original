namespace rail;

public interface IRailRoom : IRailComponent
{

	public RailResult AsyncClearRoomMetadata(List<String> keys, string user_data) { }

	public RailResult AsyncGetAllRoomData(string user_data) { }

	public RailResult AsyncGetMemberMetadata(RailID member_id, List<String> keys, string user_data) { }

	public RailResult AsyncGetRoomMembers(string user_data) { }

	public RailResult AsyncGetRoomMetadata(List<String> keys, string user_data) { }

	public RailResult AsyncGetRoomTag(string user_data) { }

	public RailResult AsyncJoinRoom(string password, string user_data) { }

	public RailResult AsyncKickOffMember(RailID member_id, string user_data) { }

	public RailResult AsyncSetMemberMetadata(RailID member_id, List<RailKeyValue> key_values, string user_data) { }

	public RailResult AsyncSetNewRoomOwner(RailID new_owner_id, string user_data) { }

	public RailResult AsyncSetRoomMaxMember(uint max_member, string user_data) { }

	public RailResult AsyncSetRoomMetadata(List<RailKeyValue> key_values, string user_data) { }

	public RailResult AsyncSetRoomTag(string room_tag, string user_data) { }

	public RailResult AsyncSetRoomType(EnumRoomType room_type, string user_data) { }

	public RailResult EnableTeamVoice(bool enable) { }

	public RailResult GetFriendsInRoom(List<RailID> friend_ids) { }

	public RailID GetGameServerID() { }

	public uint GetMaxMembers() { }

	public RailID GetMemberByIndex(uint index) { }

	public RailResult GetMemberNameByIndex(uint index, out string name) { }

	public uint GetMembers() { }

	public RailID GetOwnerID() { }

	public ulong GetRoomID() { }

	public RailResult GetRoomName(out string name) { }

	public EnumRoomType GetRoomType() { }

	public bool HasPassword() { }

	public bool IsRoomJoinable() { }

	public bool IsUserInRoom(RailID user_rail_id) { }

	public void Leave() { }

	public RailResult SendDataToMember(RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public RailResult SendDataToMember(RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public RailResult SetGameServerID(RailID game_server_rail_id) { }

	public RailResult SetRoomJoinable(bool is_joinable) { }

}


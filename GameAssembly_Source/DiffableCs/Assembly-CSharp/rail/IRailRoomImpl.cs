namespace rail;

public class IRailRoomImpl : RailObject, IRailRoom, IRailComponent
{

	internal IRailRoomImpl(IntPtr cPtr) { }

	public override RailResult AsyncClearRoomMetadata(List<String> keys, string user_data) { }

	public override RailResult AsyncGetAllRoomData(string user_data) { }

	public override RailResult AsyncGetMemberMetadata(RailID member_id, List<String> keys, string user_data) { }

	public override RailResult AsyncGetRoomMembers(string user_data) { }

	public override RailResult AsyncGetRoomMetadata(List<String> keys, string user_data) { }

	public override RailResult AsyncGetRoomTag(string user_data) { }

	public override RailResult AsyncJoinRoom(string password, string user_data) { }

	public override RailResult AsyncKickOffMember(RailID member_id, string user_data) { }

	public override RailResult AsyncSetMemberMetadata(RailID member_id, List<RailKeyValue> key_values, string user_data) { }

	public override RailResult AsyncSetNewRoomOwner(RailID new_owner_id, string user_data) { }

	public override RailResult AsyncSetRoomMaxMember(uint max_member, string user_data) { }

	public override RailResult AsyncSetRoomMetadata(List<RailKeyValue> key_values, string user_data) { }

	public override RailResult AsyncSetRoomTag(string room_tag, string user_data) { }

	public override RailResult AsyncSetRoomType(EnumRoomType room_type, string user_data) { }

	public override RailResult EnableTeamVoice(bool enable) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailResult GetFriendsInRoom(List<RailID> friend_ids) { }

	public override RailID GetGameServerID() { }

	public override uint GetMaxMembers() { }

	public override RailID GetMemberByIndex(uint index) { }

	public override RailResult GetMemberNameByIndex(uint index, out string name) { }

	public override uint GetMembers() { }

	public override RailID GetOwnerID() { }

	public override ulong GetRoomID() { }

	public override RailResult GetRoomName(out string name) { }

	public override EnumRoomType GetRoomType() { }

	public override bool HasPassword() { }

	public override bool IsRoomJoinable() { }

	public override bool IsUserInRoom(RailID user_rail_id) { }

	public override void Leave() { }

	public override void Release() { }

	public override RailResult SendDataToMember(RailID remote_peer, Byte[] data_buf, uint data_len) { }

	public override RailResult SendDataToMember(RailID remote_peer, Byte[] data_buf, uint data_len, uint message_type) { }

	public override RailResult SetGameServerID(RailID game_server_rail_id) { }

	public override RailResult SetRoomJoinable(bool is_joinable) { }

}


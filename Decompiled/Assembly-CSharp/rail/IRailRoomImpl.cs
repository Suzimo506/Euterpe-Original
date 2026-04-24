using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024D")]
public class IRailRoomImpl : RailObject, IRailRoom, IRailComponent
{
	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailRoomImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailRoomImpl()
	{
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x36B5A0", Offset = "0x369DA0", Length = "0x100")]
	public virtual RailResult AsyncJoinRoom(string password, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x36CAB0", Offset = "0x36B2B0", Length = "0xB5")]
	public virtual ulong GetRoomID()
	{
		return default(ulong);
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x36CB70", Offset = "0x36B370", Length = "0x1E9")]
	public virtual RailResult GetRoomName(out string name)
	{
		name = null;
		return default(RailResult);
	}

	[Address(RVA = "0x36C9C0", Offset = "0x36B1C0", Length = "0xEB")]
	[Token(Token = "0x60028D5")]
	public virtual RailID GetOwnerID()
	{
		return null;
	}

	[Address(RVA = "0x36CE20", Offset = "0x36B620", Length = "0xBA")]
	[Token(Token = "0x60028D6")]
	public virtual bool HasPassword()
	{
		return default(bool);
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x36CD60", Offset = "0x36B560", Length = "0xB5")]
	public virtual EnumRoomType GetRoomType()
	{
		return default(EnumRoomType);
	}

	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x36C900", Offset = "0x36B100", Length = "0xB5")]
	public virtual uint GetMembers()
	{
		return default(uint);
	}

	[Address(RVA = "0x36C610", Offset = "0x36AE10", Length = "0xEF")]
	[Token(Token = "0x60028D9")]
	public virtual RailID GetMemberByIndex(uint index)
	{
		return null;
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x36C700", Offset = "0x36AF00", Length = "0x1F0")]
	public virtual RailResult GetMemberNameByIndex(uint index, out string name)
	{
		name = null;
		return default(RailResult);
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x36C550", Offset = "0x36AD50", Length = "0xB5")]
	public virtual uint GetMaxMembers()
	{
		return default(uint);
	}

	[Address(RVA = "0x36D180", Offset = "0x36B980", Length = "0xB5")]
	[Token(Token = "0x60028DC")]
	public virtual void Leave()
	{
	}

	[Address(RVA = "0x36BB10", Offset = "0x36A310", Length = "0x1F3")]
	[Token(Token = "0x60028DD")]
	public virtual RailResult AsyncSetNewRoomOwner(RailID new_owner_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x36B230", Offset = "0x369A30", Length = "0xDD")]
	public virtual RailResult AsyncGetRoomMembers(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x36AEE0", Offset = "0x3696E0", Length = "0xDD")]
	public virtual RailResult AsyncGetAllRoomData(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x36B6A0", Offset = "0x369EA0", Length = "0x1F3")]
	public virtual RailResult AsyncKickOffMember(RailID member_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36BFB0", Offset = "0x36A7B0", Length = "0x100")]
	[Token(Token = "0x60028E1")]
	public virtual RailResult AsyncSetRoomTag(string room_tag, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x36B4C0", Offset = "0x369CC0", Length = "0xDD")]
	public virtual RailResult AsyncGetRoomTag(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x36BE00", Offset = "0x36A600", Length = "0x1A0")]
	public virtual RailResult AsyncSetRoomMetadata(List<RailKeyValue> key_values, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x36B310", Offset = "0x369B10", Length = "0x1A0")]
	public virtual RailResult AsyncGetRoomMetadata(List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x36AD30", Offset = "0x369530", Length = "0x1A0")]
	public virtual RailResult AsyncClearRoomMetadata(List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x36B8A0", Offset = "0x36A0A0", Length = "0x262")]
	public virtual RailResult AsyncSetMemberMetadata(RailID member_id, List<RailKeyValue> key_values, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x36AFC0", Offset = "0x3697C0", Length = "0x262")]
	public virtual RailResult AsyncGetMemberMetadata(RailID member_id, List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x36D4A0", Offset = "0x36BCA0", Length = "0x206")]
	public virtual RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len, uint message_type)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x36D2A0", Offset = "0x36BAA0", Length = "0x1FC")]
	public virtual RailResult SendDataToMember(RailID remote_peer, byte[] data_buf, uint data_len)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x36D6B0", Offset = "0x36BEB0", Length = "0x1D1")]
	public virtual RailResult SetGameServerID(RailID game_server_rail_id)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x36C460", Offset = "0x36AC60", Length = "0xEB")]
	public virtual RailID GetGameServerID()
	{
		return null;
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x36D890", Offset = "0x36C090", Length = "0xC3")]
	public virtual RailResult SetRoomJoinable(bool is_joinable)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36CEE0", Offset = "0x36B6E0", Length = "0xBA")]
	[Token(Token = "0x60028ED")]
	public virtual bool IsRoomJoinable()
	{
		return default(bool);
	}

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x36C2D0", Offset = "0x36AAD0", Length = "0x18B")]
	public virtual RailResult GetFriendsInRoom(List<RailID> friend_ids)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x36CFA0", Offset = "0x36B7A0", Length = "0x1DA")]
	public virtual bool IsUserInRoom(RailID user_rail_id)
	{
		return default(bool);
	}

	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x36C1A0", Offset = "0x36A9A0", Length = "0xC3")]
	public virtual RailResult EnableTeamVoice(bool enable)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36C0B0", Offset = "0x36A8B0", Length = "0xEB")]
	[Token(Token = "0x60028F1")]
	public virtual RailResult AsyncSetRoomType(EnumRoomType room_type, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36BD10", Offset = "0x36A510", Length = "0xEB")]
	[Token(Token = "0x60028F2")]
	public virtual RailResult AsyncSetRoomMaxMember(uint max_member, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36C270", Offset = "0x36AA70", Length = "0x55")]
	[Token(Token = "0x60028F3")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Address(RVA = "0x36D240", Offset = "0x36BA40", Length = "0x55")]
	[Token(Token = "0x60028F4")]
	public virtual void Release()
	{
	}
}

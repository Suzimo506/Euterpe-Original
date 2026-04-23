using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000237")]
public class IRailFriendsImpl : RailObject, IRailFriends
{
	[Token(Token = "0x60027C0")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailFriendsImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60027C1")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailFriendsImpl()
	{
	}

	[Token(Token = "0x60027C2")]
	[Address(RVA = "0xD264B0", Offset = "0xD24CB0", Length = "0x128")]
	public virtual RailResult AsyncGetPersonalInfo(List<RailID> rail_ids, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26140", Offset = "0xD24940", Length = "0x1E3")]
	[Token(Token = "0x60027C3")]
	public virtual RailResult AsyncGetFriendMetadata(RailID rail_id, List<string> keys, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027C4")]
	[Address(RVA = "0xD26BE0", Offset = "0xD253E0", Length = "0x128")]
	public virtual RailResult AsyncSetMyMetadata(List<RailKeyValue> key_values, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0xD260D0", Offset = "0xD248D0", Length = "0x65")]
	public virtual RailResult AsyncClearAllMyMetadata(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0xD26B60", Offset = "0xD25360", Length = "0x75")]
	public virtual RailResult AsyncSetInviteCommandLine(string command_line, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26330", Offset = "0xD24B30", Length = "0x17B")]
	[Token(Token = "0x60027C7")]
	public virtual RailResult AsyncGetInviteCommandLine(RailID rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26A30", Offset = "0xD25230", Length = "0x128")]
	[Token(Token = "0x60027C8")]
	public virtual RailResult AsyncReportPlayedWithUserList(List<RailUserPlayedWith> player_list, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027C9")]
	[Address(RVA = "0xD26D80", Offset = "0xD25580", Length = "0x12E")]
	public virtual RailResult GetFriendsList(List<RailFriendInfo> friends_list)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD265E0", Offset = "0xD24DE0", Length = "0x17B")]
	[Token(Token = "0x60027CA")]
	public virtual RailResult AsyncQueryFriendPlayedGamesInfo(RailID rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26890", Offset = "0xD25090", Length = "0x65")]
	[Token(Token = "0x60027CB")]
	public virtual RailResult AsyncQueryPlayedWithFriendsList(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027CC")]
	[Address(RVA = "0xD26900", Offset = "0xD25100", Length = "0x128")]
	public virtual RailResult AsyncQueryPlayedWithFriendsTime(List<RailID> rail_ids, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26760", Offset = "0xD24F60", Length = "0x128")]
	[Token(Token = "0x60027CD")]
	public virtual RailResult AsyncQueryPlayedWithFriendsGames(List<RailID> rail_ids, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD25FA0", Offset = "0xD247A0", Length = "0x128")]
	[Token(Token = "0x60027CE")]
	public virtual RailResult AsyncAddFriend(RailFriendsAddFriendRequest request, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD26D10", Offset = "0xD25510", Length = "0x65")]
	[Token(Token = "0x60027CF")]
	public virtual RailResult AsyncUpdateFriendsData(string user_data)
	{
		return default(RailResult);
	}
}

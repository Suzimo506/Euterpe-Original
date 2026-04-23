using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003BB")]
public interface IRailUsersHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F64")]
	RailResult AsyncGetUsersInfo(List<RailID> rail_ids, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F65")]
	RailResult AsyncInviteUsers(string command_line, List<RailID> users, RailInviteOptions options, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F66")]
	RailResult AsyncGetInviteDetail(RailID inviter, EnumRailUsersInviteType invite_type, string user_data);

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncCancelInvite(EnumRailUsersInviteType invite_type, string user_data);

	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncCancelAllInvites(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F69")]
	RailResult AsyncGetUserLimits(RailID user_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F6A")]
	RailResult AsyncShowChatWindowWithFriend(RailID rail_id, string user_data);

	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncShowUserHomepageWindow(RailID rail_id, string user_data);
}

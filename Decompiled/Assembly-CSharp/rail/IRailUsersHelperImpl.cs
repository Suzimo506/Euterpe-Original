using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000258")]
public class IRailUsersHelperImpl : RailObject, IRailUsersHelper
{
	[Token(Token = "0x600297D")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailUsersHelperImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600297E")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailUsersHelperImpl()
	{
	}

	[Token(Token = "0x600297F")]
	[Address(RVA = "0x3787B0", Offset = "0x376FB0", Length = "0x1A0")]
	public virtual RailResult AsyncGetUsersInfo(List<RailID> rail_ids, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002980")]
	[Address(RVA = "0x378960", Offset = "0x377160", Length = "0x2D4")]
	public virtual RailResult AsyncInviteUsers(string command_line, List<RailID> users, RailInviteOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002981")]
	[Address(RVA = "0x3783A0", Offset = "0x376BA0", Length = "0x209")]
	public virtual RailResult AsyncGetInviteDetail(RailID inviter, EnumRailUsersInviteType invite_type, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3782B0", Offset = "0x376AB0", Length = "0xEB")]
	[Token(Token = "0x6002982")]
	public virtual RailResult AsyncCancelInvite(EnumRailUsersInviteType invite_type, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x3781D0", Offset = "0x3769D0", Length = "0xDD")]
	[Token(Token = "0x6002983")]
	public virtual RailResult AsyncCancelAllInvites(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002984")]
	[Address(RVA = "0x3785B0", Offset = "0x376DB0", Length = "0x1F3")]
	public virtual RailResult AsyncGetUserLimits(RailID user_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002985")]
	[Address(RVA = "0x378C40", Offset = "0x377440", Length = "0x1F3")]
	public virtual RailResult AsyncShowChatWindowWithFriend(RailID rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x378E40", Offset = "0x377640", Length = "0x1F3")]
	[Token(Token = "0x6002986")]
	public virtual RailResult AsyncShowUserHomepageWindow(RailID rail_id, string user_data)
	{
		return default(RailResult);
	}
}

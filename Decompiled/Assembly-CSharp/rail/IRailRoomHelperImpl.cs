using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200024E")]
public class IRailRoomHelperImpl : RailObject, IRailRoomHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x60028F5")]
	internal IRailRoomHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60028F6")]
	~IRailRoomHelperImpl()
	{
	}

	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x36AA20", Offset = "0x369220", Length = "0x1EE")]
	public virtual IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x36A0E0", Offset = "0x3688E0", Length = "0x208")]
	public virtual IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data)
	{
		return null;
	}

	[Address(RVA = "0x36AC10", Offset = "0x369410", Length = "0x11A")]
	[Token(Token = "0x60028F9")]
	public virtual IRailRoom OpenRoom(ulong room_id, out RailResult result)
	{
		System.Runtime.CompilerServices.Unsafe.As<RailResult, @null>(ref result) = null;
		return null;
	}

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x36A8F0", Offset = "0x3690F0", Length = "0x12B")]
	public virtual IRailRoom AsyncOpenRoom(ulong room_id, string user_data)
	{
		return null;
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x36A530", Offset = "0x368D30", Length = "0x2D1")]
	public virtual RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x36A2F0", Offset = "0x368AF0", Length = "0x230")]
	public virtual RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<string> room_tags, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0x36A810", Offset = "0x369010", Length = "0xDD")]
	[Token(Token = "0x60028FD")]
	public virtual RailResult AsyncGetUserRoomList(string user_data)
	{
		return default(RailResult);
	}
}

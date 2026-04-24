using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000342")]
public interface IRailRoomHelper
{
	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailRoom CreateRoom(RoomOptions options, string room_name, out RailResult result);

	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailRoom AsyncCreateRoom(RoomOptions options, string room_name, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E74")]
	IRailRoom OpenRoom(ulong room_id, out RailResult result);

	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailRoom AsyncOpenRoom(ulong room_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002E76")]
	RailResult AsyncGetRoomList(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<RoomInfoListFilter> filter, string user_data);

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetRoomListByTags(uint start_index, uint end_index, List<RoomInfoListSorter> sorter, List<string> room_tags, string user_data);

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetUserRoomList(string user_data);
}

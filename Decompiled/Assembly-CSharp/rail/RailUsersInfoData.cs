using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003C5")]
public class RailUsersInfoData : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001599")]
	public List<PlayerPersonalInfo> user_info_list;

	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x27218C0", Offset = "0x27200C0", Length = "0x69")]
	public RailUsersInfoData()
	{
	}
}

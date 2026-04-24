using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002F7")]
public class RailQueryGroupsInfoResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400121E")]
	public List<string> group_ids;

	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x27210A0", Offset = "0x271F8A0", Length = "0x69")]
	public RailQueryGroupsInfoResult()
	{
	}
}

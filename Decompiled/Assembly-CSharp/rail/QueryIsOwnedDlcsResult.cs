using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002AE")]
public class QueryIsOwnedDlcsResult : EventBase
{
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x30")]
	public List<RailDlcOwned> dlc_owned_list;

	[Address(RVA = "0x37EA20", Offset = "0x37D220", Length = "0x69")]
	[Token(Token = "0x6002D14")]
	public QueryIsOwnedDlcsResult()
	{
	}
}

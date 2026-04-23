using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000371")]
public class RailSmallObjectStateQueryResult : EventBase
{
	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0x30")]
	public List<RailSmallObjectState> objects_state;

	[Address(RVA = "0x2721180", Offset = "0x271F980", Length = "0x69")]
	[Token(Token = "0x6002EAB")]
	public RailSmallObjectStateQueryResult()
	{
	}
}

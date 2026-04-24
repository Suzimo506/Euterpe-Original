using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200033D")]
public class RailGetPlayerMetadataResult : EventBase
{
	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0x30")]
	public List<RailKeyValue> key_values;

	[Address(RVA = "0x2720840", Offset = "0x271F040", Length = "0x69")]
	[Token(Token = "0x6002E4F")]
	public RailGetPlayerMetadataResult()
	{
	}
}

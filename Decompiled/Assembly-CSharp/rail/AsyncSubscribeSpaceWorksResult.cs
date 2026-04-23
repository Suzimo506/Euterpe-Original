using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039F")]
public class AsyncSubscribeSpaceWorksResult : EventBase
{
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x30")]
	public List<SpaceWorkID> success_ids;

	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x38")]
	public List<SpaceWorkID> failure_ids;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001506")]
	public bool subscribe;

	[Address(RVA = "0xD1F710", Offset = "0xD1DF10", Length = "0x96")]
	[Token(Token = "0x6002F52")]
	public AsyncSubscribeSpaceWorksResult()
	{
	}
}

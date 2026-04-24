using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039A")]
public class AsyncModifyFavoritesWorksResult : EventBase
{
	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x30")]
	public List<SpaceWorkID> success_ids;

	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x38")]
	public List<SpaceWorkID> failure_ids;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014FD")]
	public EnumRailModifyFavoritesSpaceWorkType modify_flag;

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0xD1F440", Offset = "0xD1DC40", Length = "0x96")]
	public AsyncModifyFavoritesWorksResult()
	{
	}
}

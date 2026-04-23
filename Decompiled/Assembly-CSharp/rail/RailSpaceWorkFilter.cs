using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B0")]
public class RailSpaceWorkFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001553")]
	public List<EnumRailWorkFileClass> classes;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001554")]
	public List<EnumRailSpaceWorkType> type;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001555")]
	public List<RailID> collector_list;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001556")]
	public List<RailID> subscriber_list;

	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x30")]
	public List<RailID> creator_list;

	[Address(RVA = "0x27212F0", Offset = "0x271FAF0", Length = "0x11D")]
	[Token(Token = "0x6002F58")]
	public RailSpaceWorkFilter()
	{
	}
}

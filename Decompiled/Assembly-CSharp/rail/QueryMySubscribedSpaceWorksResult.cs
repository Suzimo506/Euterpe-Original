using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003AD")]
public class QueryMySubscribedSpaceWorksResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400153F")]
	public uint total_available_works;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x14")]
	public EnumRailSpaceWorkType spacework_type;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001541")]
	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[Token(Token = "0x6002F55")]
	[Address(RVA = "0x37EA90", Offset = "0x37D290", Length = "0x69")]
	public QueryMySubscribedSpaceWorksResult()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039E")]
public class AsyncSearchSpaceWorksResult : EventBase
{
	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x30")]
	public uint total_available_works;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001503")]
	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[Address(RVA = "0xD1F6A0", Offset = "0xD1DEA0", Length = "0x69")]
	[Token(Token = "0x6002F51")]
	public AsyncSearchSpaceWorksResult()
	{
	}
}

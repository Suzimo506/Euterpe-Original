using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039B")]
public class AsyncQuerySpaceWorksResult : EventBase
{
	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x30")]
	public uint total_available_works;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014FF")]
	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0xD1F4E0", Offset = "0xD1DCE0", Length = "0x69")]
	public AsyncQuerySpaceWorksResult()
	{
	}
}

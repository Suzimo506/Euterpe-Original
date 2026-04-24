using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000399")]
public class AsyncGetMySubscribedWorksResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014F9")]
	public uint total_available_works;

	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x38")]
	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0xD1F360", Offset = "0xD1DB60", Length = "0x69")]
	public AsyncGetMySubscribedWorksResult()
	{
	}
}

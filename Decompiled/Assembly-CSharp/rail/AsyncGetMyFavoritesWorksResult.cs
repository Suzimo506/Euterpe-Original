using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000398")]
public class AsyncGetMyFavoritesWorksResult : EventBase
{
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x30")]
	public uint total_available_works;

	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x38")]
	public List<RailSpaceWorkDescriptor> spacework_descriptors;

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0xD1F2F0", Offset = "0xD1DAF0", Length = "0x69")]
	public AsyncGetMyFavoritesWorksResult()
	{
	}
}

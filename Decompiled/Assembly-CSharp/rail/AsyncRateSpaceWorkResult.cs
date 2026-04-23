using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039C")]
public class AsyncRateSpaceWorkResult : EventBase
{
	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x30")]
	public SpaceWorkID id;

	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0xD1F550", Offset = "0xD1DD50", Length = "0x64")]
	public AsyncRateSpaceWorkResult()
	{
	}
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200039D")]
public class AsyncRemoveSpaceWorkResult : EventBase
{
	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x30")]
	public SpaceWorkID id;

	[Address(RVA = "0xD1F630", Offset = "0xD1DE30", Length = "0x64")]
	[Token(Token = "0x6002F50")]
	public AsyncRemoveSpaceWorkResult()
	{
	}
}

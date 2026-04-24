using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003A1")]
public class AsyncVoteSpaceWorkResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001509")]
	public SpaceWorkID id;

	[Token(Token = "0x6002F54")]
	[Address(RVA = "0xD1F820", Offset = "0xD1E020", Length = "0x64")]
	public AsyncVoteSpaceWorkResult()
	{
	}
}

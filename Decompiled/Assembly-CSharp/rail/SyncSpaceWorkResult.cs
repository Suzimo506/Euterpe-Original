using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20003B8")]
public class SyncSpaceWorkResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001577")]
	public SpaceWorkID id;

	[Address(RVA = "0x2722450", Offset = "0x2720C50", Length = "0x9D")]
	[Token(Token = "0x6002F61")]
	public SyncSpaceWorkResult()
	{
	}
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000264")]
public class GlobalAchievementReceived : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FCE")]
	public int count;

	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public GlobalAchievementReceived()
	{
	}
}

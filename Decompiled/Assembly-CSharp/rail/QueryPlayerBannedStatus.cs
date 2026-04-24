using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000339")]
public class QueryPlayerBannedStatus : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012BF")]
	public EnumRailPlayerBannedStatus status;

	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public QueryPlayerBannedStatus()
	{
	}
}

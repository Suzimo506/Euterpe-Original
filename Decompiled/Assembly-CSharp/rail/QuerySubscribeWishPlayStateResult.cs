using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002DC")]
public class QuerySubscribeWishPlayStateResult : EventBase
{
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x30")]
	public bool is_subscribed;

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public QuerySubscribeWishPlayStateResult()
	{
	}
}

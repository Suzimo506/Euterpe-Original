using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000337")]
public class PlayerGetGamePurchaseKeyResult : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012B8")]
	public string purchase_key;

	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public PlayerGetGamePurchaseKeyResult()
	{
	}
}

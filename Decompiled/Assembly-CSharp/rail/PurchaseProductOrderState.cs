using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030C")]
public enum PurchaseProductOrderState
{
	[Token(Token = "0x4001248")]
	kPurchaseProductOrderStateInvalid = 0,
	[Token(Token = "0x4001249")]
	kPurchaseProductOrderStateCreateOrderOk = 100,
	[Token(Token = "0x400124A")]
	kPurchaseProductOrderStatePayOk = 200,
	[Token(Token = "0x400124B")]
	kPurchaseProductOrderStateDeliverOk = 300
}

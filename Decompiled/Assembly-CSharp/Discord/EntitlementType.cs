using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000419")]
public enum EntitlementType
{
	[Token(Token = "0x40016F6")]
	Purchase = 1,
	[Token(Token = "0x40016F7")]
	PremiumSubscription,
	[Token(Token = "0x40016F8")]
	DeveloperGift,
	[Token(Token = "0x40016F9")]
	TestModePurchase,
	[Token(Token = "0x40016FA")]
	FreePurchase,
	[Token(Token = "0x40016FB")]
	UserGift,
	[Token(Token = "0x40016FC")]
	PremiumPurchase
}

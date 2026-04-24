using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200030B")]
public enum PurchaseProductDiscountType
{
	[Token(Token = "0x4001243")]
	kPurchaseProductDiscountTypeInvalid,
	[Token(Token = "0x4001244")]
	kPurchaseProductDiscountTypeNone,
	[Token(Token = "0x4001245")]
	kPurchaseProductDiscountTypePermanent,
	[Token(Token = "0x4001246")]
	kPurchaseProductDiscountTypeTimed
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000272")]
public enum EnumRailAssetOrigin
{
	[Token(Token = "0x4000FDA")]
	kRailAssetOriginGenerate = 1,
	[Token(Token = "0x4000FDB")]
	kRailAssetOriginPurchase,
	[Token(Token = "0x4000FDC")]
	kRailAssetOriginFriends,
	[Token(Token = "0x4000FDD")]
	kRailAssetOriginTrade,
	[Token(Token = "0x4000FDE")]
	kRailAssetOriginMarket,
	[Token(Token = "0x4000FDF")]
	kRailAssetOriginPromo,
	[Token(Token = "0x4000FE0")]
	kRailAssetOriginExchange,
	[Token(Token = "0x4000FE1")]
	kRailAssetOriginDrop
}

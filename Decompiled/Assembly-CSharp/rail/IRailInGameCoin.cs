using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000303")]
public interface IRailInGameCoin
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DEA")]
	RailResult AsyncRequestCoinInfo(string user_data);

	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncPurchaseCoins(RailCoins purchase_info, string user_data);
}

using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000315")]
public interface IRailInGameStorePurchaseHelper
{
	[Token(Token = "0x6002DFF")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncShowPaymentWindow(string order_id, string user_data);
}

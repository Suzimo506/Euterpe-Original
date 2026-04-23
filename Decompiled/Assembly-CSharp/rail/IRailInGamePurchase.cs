using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000309")]
public interface IRailInGamePurchase
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DF1")]
	RailResult AsyncRequestAllPurchasableProducts(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DF2")]
	RailResult AsyncRequestAllProducts(string user_data);

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DF4")]
	RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DF5")]
	RailResult AsyncFinishOrder(string order_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DF6")]
	RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data);
}

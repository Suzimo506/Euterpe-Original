using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000244")]
public class IRailInGamePurchaseImpl : RailObject, IRailInGamePurchase
{
	[Token(Token = "0x6002866")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailInGamePurchaseImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x6002867")]
	~IRailInGamePurchaseImpl()
	{
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0xD2D060", Offset = "0xD2B860", Length = "0x65")]
	public virtual RailResult AsyncRequestAllPurchasableProducts(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0xD2CFF0", Offset = "0xD2B7F0", Length = "0x65")]
	public virtual RailResult AsyncRequestAllProducts(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0xD2D0D0", Offset = "0xD2B8D0", Length = "0x132")]
	public virtual RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD2CEC0", Offset = "0xD2B6C0", Length = "0x128")]
	[Token(Token = "0x600286B")]
	public virtual RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600286C")]
	[Address(RVA = "0xD2CD10", Offset = "0xD2B510", Length = "0x75")]
	public virtual RailResult AsyncFinishOrder(string order_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600286D")]
	[Address(RVA = "0xD2CD90", Offset = "0xD2B590", Length = "0x128")]
	public virtual RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data)
	{
		return default(RailResult);
	}
}

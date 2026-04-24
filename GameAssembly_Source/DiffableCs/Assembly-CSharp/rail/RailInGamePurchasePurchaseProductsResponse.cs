namespace rail;

public class RailInGamePurchasePurchaseProductsResponse : EventBase
{
	public string order_id; //Field offset: 0x30
	public List<RailProductItem> delivered_products; //Field offset: 0x38

	public RailInGamePurchasePurchaseProductsResponse() { }

}


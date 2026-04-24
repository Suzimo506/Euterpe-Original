namespace rail;

public interface IRailInGamePurchase
{

	public RailResult AsyncFinishOrder(string order_id, string user_data) { }

	public RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data) { }

	public RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data) { }

	public RailResult AsyncRequestAllProducts(string user_data) { }

	public RailResult AsyncRequestAllPurchasableProducts(string user_data) { }

	public RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product) { }

}


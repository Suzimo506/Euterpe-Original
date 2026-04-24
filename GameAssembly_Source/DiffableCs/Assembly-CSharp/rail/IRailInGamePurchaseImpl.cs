namespace rail;

public class IRailInGamePurchaseImpl : RailObject, IRailInGamePurchase
{

	internal IRailInGamePurchaseImpl(IntPtr cPtr) { }

	public override RailResult AsyncFinishOrder(string order_id, string user_data) { }

	public override RailResult AsyncPurchaseProducts(List<RailProductItem> cart_items, string user_data) { }

	public override RailResult AsyncPurchaseProductsToAssets(List<RailProductItem> cart_items, string user_data) { }

	public override RailResult AsyncRequestAllProducts(string user_data) { }

	public override RailResult AsyncRequestAllPurchasableProducts(string user_data) { }

	protected virtual void Finalize() { }

	public override RailResult GetProductInfo(uint product_id, RailPurchaseProductInfo product) { }

}


namespace rail;

public class RailInGamePurchasePurchaseProductsToAssetsResponse : EventBase
{
	public string order_id; //Field offset: 0x30
	public List<RailAssetInfo> delivered_assets; //Field offset: 0x38

	public RailInGamePurchasePurchaseProductsToAssetsResponse() { }

}


namespace rail;

public class ExchangeAssetsToFinished : EventBase
{
	public ulong exchange_to_asset_id; //Field offset: 0x30
	public RailProductItem to_product_info; //Field offset: 0x38
	public List<RailAssetItem> old_assets; //Field offset: 0x40

	public ExchangeAssetsToFinished() { }

}


namespace rail;

public class ExchangeAssetsFinished : EventBase
{
	public List<RailAssetItem> old_assets; //Field offset: 0x30
	public List<RailGeneratedAssetItem> new_asset_item_list; //Field offset: 0x38

	public ExchangeAssetsFinished() { }

}


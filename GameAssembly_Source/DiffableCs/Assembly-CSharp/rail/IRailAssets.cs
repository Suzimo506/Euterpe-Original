namespace rail;

public interface IRailAssets : IRailComponent
{

	public RailResult AsyncCompleteConsumeAsset(ulong asset_id, uint quantity, string user_data) { }

	public RailResult AsyncDirectConsumeAssets(List<RailAssetItem> assets, string user_data) { }

	public RailResult AsyncExchangeAssets(List<RailAssetItem> old_assets, RailProductItem to_product_info, string user_data) { }

	public RailResult AsyncExchangeAssetsTo(List<RailAssetItem> old_assets, RailProductItem to_product_info, ulong add_to_exist_assets, string user_data) { }

	public RailResult AsyncMergeAsset(List<RailAssetItem> source_assets, string user_data) { }

	public RailResult AsyncMergeAssetTo(List<RailAssetItem> source_assets, ulong add_to_asset, string user_data) { }

	public RailResult AsyncRequestAllAssets(string user_data) { }

	public RailResult AsyncSplitAsset(ulong source_asset, uint to_quantity, string user_data) { }

	public RailResult AsyncSplitAssetTo(ulong source_asset, uint to_quantity, ulong add_to_asset, string user_data) { }

	public RailResult AsyncStartConsumeAsset(ulong asset_id, string user_data) { }

	public RailResult AsyncUpdateAssetsProperty(List<RailAssetProperty> asset_property_list, string user_data) { }

	public RailResult AsyncUpdateConsumeProgress(ulong asset_id, string progress, string user_data) { }

	public RailResult DeserializeAssetsFromBuffer(RailID assets_owner, string buffer, List<RailAssetInfo> assets_info) { }

	public RailResult QueryAssetInfo(ulong asset_id, RailAssetInfo asset_info) { }

	public RailResult SerializeAssetsToBuffer(out string buffer) { }

	public RailResult SerializeAssetsToBuffer(List<UInt64> assets, out string buffer) { }

}


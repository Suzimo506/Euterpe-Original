namespace rail;

public class IRailAssetsImpl : RailObject, IRailAssets, IRailComponent
{

	internal IRailAssetsImpl(IntPtr cPtr) { }

	public override RailResult AsyncCompleteConsumeAsset(ulong asset_id, uint quantity, string user_data) { }

	public override RailResult AsyncDirectConsumeAssets(List<RailAssetItem> assets, string user_data) { }

	public override RailResult AsyncExchangeAssets(List<RailAssetItem> old_assets, RailProductItem to_product_info, string user_data) { }

	public override RailResult AsyncExchangeAssetsTo(List<RailAssetItem> old_assets, RailProductItem to_product_info, ulong add_to_exist_assets, string user_data) { }

	public override RailResult AsyncMergeAsset(List<RailAssetItem> source_assets, string user_data) { }

	public override RailResult AsyncMergeAssetTo(List<RailAssetItem> source_assets, ulong add_to_asset, string user_data) { }

	public override RailResult AsyncRequestAllAssets(string user_data) { }

	public override RailResult AsyncSplitAsset(ulong source_asset, uint to_quantity, string user_data) { }

	public override RailResult AsyncSplitAssetTo(ulong source_asset, uint to_quantity, ulong add_to_asset, string user_data) { }

	public override RailResult AsyncStartConsumeAsset(ulong asset_id, string user_data) { }

	public override RailResult AsyncUpdateAssetsProperty(List<RailAssetProperty> asset_property_list, string user_data) { }

	public override RailResult AsyncUpdateConsumeProgress(ulong asset_id, string progress, string user_data) { }

	public override RailResult DeserializeAssetsFromBuffer(RailID assets_owner, string buffer, List<RailAssetInfo> assets_info) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override RailResult QueryAssetInfo(ulong asset_id, RailAssetInfo asset_info) { }

	public override void Release() { }

	public override RailResult SerializeAssetsToBuffer(out string buffer) { }

	public override RailResult SerializeAssetsToBuffer(List<UInt64> assets, out string buffer) { }

}


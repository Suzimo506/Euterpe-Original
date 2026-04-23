using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200026C")]
public interface IRailAssets : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C9A")]
	RailResult AsyncRequestAllAssets(string user_data);

	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult QueryAssetInfo(ulong asset_id, RailAssetInfo asset_info);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C9C")]
	RailResult AsyncUpdateAssetsProperty(List<RailAssetProperty> asset_property_list, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C9D")]
	RailResult AsyncDirectConsumeAssets(List<RailAssetItem> assets, string user_data);

	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncStartConsumeAsset(ulong asset_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002C9F")]
	RailResult AsyncUpdateConsumeProgress(ulong asset_id, string progress, string user_data);

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncCompleteConsumeAsset(ulong asset_id, uint quantity, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CA1")]
	RailResult AsyncExchangeAssets(List<RailAssetItem> old_assets, RailProductItem to_product_info, string user_data);

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncExchangeAssetsTo(List<RailAssetItem> old_assets, RailProductItem to_product_info, ulong add_to_exist_assets, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CA3")]
	RailResult AsyncSplitAsset(ulong source_asset, uint to_quantity, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CA4")]
	RailResult AsyncSplitAssetTo(ulong source_asset, uint to_quantity, ulong add_to_asset, string user_data);

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncMergeAsset(List<RailAssetItem> source_assets, string user_data);

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncMergeAssetTo(List<RailAssetItem> source_assets, ulong add_to_asset, string user_data);

	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SerializeAssetsToBuffer(out string buffer);

	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SerializeAssetsToBuffer(List<ulong> assets, out string buffer);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002CA9")]
	RailResult DeserializeAssetsFromBuffer(RailID assets_owner, string buffer, List<RailAssetInfo> assets_info);
}

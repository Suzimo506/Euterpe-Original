using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022E")]
public class IRailAssetsImpl : RailObject, IRailAssets, IRailComponent
{
	[Token(Token = "0x600273A")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailAssetsImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600273B")]
	~IRailAssetsImpl()
	{
	}

	[Address(RVA = "0xD21550", Offset = "0xD1FD50", Length = "0x65")]
	[Token(Token = "0x600273C")]
	public virtual RailResult AsyncRequestAllAssets(string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD21B90", Offset = "0xD20390", Length = "0x132")]
	[Token(Token = "0x600273D")]
	public virtual RailResult QueryAssetInfo(ulong asset_id, RailAssetInfo asset_info)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD21760", Offset = "0xD1FF60", Length = "0x128")]
	[Token(Token = "0x600273E")]
	public virtual RailResult AsyncUpdateAssetsProperty(List<RailAssetProperty> asset_property_list, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600273F")]
	[Address(RVA = "0xD20E80", Offset = "0xD1F680", Length = "0x128")]
	public virtual RailResult AsyncDirectConsumeAssets(List<RailAssetItem> assets, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002740")]
	[Address(RVA = "0xD216E0", Offset = "0xD1FEE0", Length = "0x75")]
	public virtual RailResult AsyncStartConsumeAsset(ulong asset_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002741")]
	[Address(RVA = "0xD21890", Offset = "0xD20090", Length = "0x8B")]
	public virtual RailResult AsyncUpdateConsumeProgress(ulong asset_id, string progress, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002742")]
	[Address(RVA = "0xD20DF0", Offset = "0xD1F5F0", Length = "0x8B")]
	public virtual RailResult AsyncCompleteConsumeAsset(ulong asset_id, uint quantity, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD21150", Offset = "0xD1F950", Length = "0x18D")]
	[Token(Token = "0x6002743")]
	public virtual RailResult AsyncExchangeAssets(List<RailAssetItem> old_assets, RailProductItem to_product_info, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD20FB0", Offset = "0xD1F7B0", Length = "0x19C")]
	[Token(Token = "0x6002744")]
	public virtual RailResult AsyncExchangeAssetsTo(List<RailAssetItem> old_assets, RailProductItem to_product_info, ulong add_to_exist_assets, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD21650", Offset = "0xD1FE50", Length = "0x8B")]
	[Token(Token = "0x6002745")]
	public virtual RailResult AsyncSplitAsset(ulong source_asset, uint to_quantity, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD215C0", Offset = "0xD1FDC0", Length = "0x8B")]
	[Token(Token = "0x6002746")]
	public virtual RailResult AsyncSplitAssetTo(ulong source_asset, uint to_quantity, ulong add_to_asset, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD21420", Offset = "0xD1FC20", Length = "0x128")]
	[Token(Token = "0x6002747")]
	public virtual RailResult AsyncMergeAsset(List<RailAssetItem> source_assets, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD212E0", Offset = "0xD1FAE0", Length = "0x13A")]
	[Token(Token = "0x6002748")]
	public virtual RailResult AsyncMergeAssetTo(List<RailAssetItem> source_assets, ulong add_to_asset, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002749")]
	[Address(RVA = "0xD21D30", Offset = "0xD20530", Length = "0x131")]
	public virtual RailResult SerializeAssetsToBuffer(out string buffer)
	{
		buffer = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD21E70", Offset = "0xD20670", Length = "0x196")]
	[Token(Token = "0x600274A")]
	public virtual RailResult SerializeAssetsToBuffer(List<ulong> assets, out string buffer)
	{
		buffer = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD21920", Offset = "0xD20120", Length = "0x207")]
	[Token(Token = "0x600274B")]
	public virtual RailResult DeserializeAssetsFromBuffer(RailID assets_owner, string buffer, List<RailAssetInfo> assets_info)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0xD21B30", Offset = "0xD20330", Length = "0x55")]
	public virtual ulong GetComponentVersion()
	{
		return default(ulong);
	}

	[Token(Token = "0x600274D")]
	[Address(RVA = "0xD21CD0", Offset = "0xD204D0", Length = "0x55")]
	public virtual void Release()
	{
	}
}

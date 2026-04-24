namespace rail;

public class MergeAssetsFinished : EventBase
{
	public List<RailAssetItem> source_assets; //Field offset: 0x30
	public ulong new_asset_id; //Field offset: 0x38

	public MergeAssetsFinished() { }

}


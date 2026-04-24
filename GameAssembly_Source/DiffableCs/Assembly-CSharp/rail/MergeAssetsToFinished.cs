namespace rail;

public class MergeAssetsToFinished : EventBase
{
	public ulong merge_to_asset_id; //Field offset: 0x30
	public List<RailAssetItem> source_assets; //Field offset: 0x38

	public MergeAssetsToFinished() { }

}


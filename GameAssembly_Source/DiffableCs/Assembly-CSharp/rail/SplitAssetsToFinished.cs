namespace rail;

public class SplitAssetsToFinished : EventBase
{
	public ulong source_asset; //Field offset: 0x30
	public uint to_quantity; //Field offset: 0x38
	public ulong split_to_asset_id; //Field offset: 0x40

	public SplitAssetsToFinished() { }

}


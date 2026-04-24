namespace rail;

public class SplitAssetsFinished : EventBase
{
	public ulong source_asset; //Field offset: 0x30
	public uint to_quantity; //Field offset: 0x38
	public ulong new_asset_id; //Field offset: 0x40

	public SplitAssetsFinished() { }

}


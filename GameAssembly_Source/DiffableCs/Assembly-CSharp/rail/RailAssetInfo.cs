namespace rail;

public class RailAssetInfo
{
	public ulong asset_id; //Field offset: 0x10
	public uint origin; //Field offset: 0x18
	public uint product_id; //Field offset: 0x1C
	public ulong container_id; //Field offset: 0x20
	public uint flag; //Field offset: 0x28
	public uint state; //Field offset: 0x2C
	public string progress; //Field offset: 0x30
	public uint expire_time; //Field offset: 0x38
	public int position; //Field offset: 0x3C
	public string product_name; //Field offset: 0x40
	public uint quantity; //Field offset: 0x48

	public RailAssetInfo() { }

}


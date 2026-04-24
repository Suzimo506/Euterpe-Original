namespace rail;

public class RailSpaceWorkSyncProgress
{
	public float progress; //Field offset: 0x10
	public ulong finished_bytes; //Field offset: 0x18
	public ulong total_bytes; //Field offset: 0x20
	public EnumRailSpaceWorkSyncState current_state; //Field offset: 0x28

	public RailSpaceWorkSyncProgress() { }

}


namespace rail;

public class RailUserSpaceDownloadResult
{
	public string err_msg; //Field offset: 0x10
	public ulong finished_bytes; //Field offset: 0x18
	public uint finished_files; //Field offset: 0x20
	public ulong total_bytes; //Field offset: 0x28
	public uint total_files; //Field offset: 0x30
	public SpaceWorkID id; //Field offset: 0x38
	public uint err_code; //Field offset: 0x40

	public RailUserSpaceDownloadResult() { }

}


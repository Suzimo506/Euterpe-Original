namespace rail;

public class UserSpaceDownloadProgress : EventBase
{
	public List<RailUserSpaceDownloadProgress> progress; //Field offset: 0x30
	public uint total_progress; //Field offset: 0x38

	public UserSpaceDownloadProgress() { }

}


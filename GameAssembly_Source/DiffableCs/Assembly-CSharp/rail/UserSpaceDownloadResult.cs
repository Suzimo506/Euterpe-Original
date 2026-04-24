namespace rail;

public class UserSpaceDownloadResult : EventBase
{
	public uint total_results; //Field offset: 0x30
	public List<RailUserSpaceDownloadResult> results; //Field offset: 0x38

	public UserSpaceDownloadResult() { }

}


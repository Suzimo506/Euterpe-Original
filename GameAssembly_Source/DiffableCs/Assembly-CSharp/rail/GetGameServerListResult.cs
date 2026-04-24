namespace rail;

public class GetGameServerListResult : EventBase
{
	public List<GameServerInfo> server_info; //Field offset: 0x30
	public uint total_num; //Field offset: 0x38
	public uint start_index; //Field offset: 0x3C
	public uint end_index; //Field offset: 0x40

	public GetGameServerListResult() { }

}


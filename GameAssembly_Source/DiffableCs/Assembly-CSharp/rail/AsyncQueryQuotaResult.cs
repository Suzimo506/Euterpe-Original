namespace rail;

public class AsyncQueryQuotaResult : EventBase
{
	public ulong available_quota; //Field offset: 0x30
	public ulong total_quota; //Field offset: 0x38

	public AsyncQueryQuotaResult() { }

}


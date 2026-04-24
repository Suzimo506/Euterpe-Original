namespace rail;

public class GetAuthenticateURLResult : EventBase
{
	public uint ticket_expire_time; //Field offset: 0x30
	public string authenticate_url; //Field offset: 0x38
	public string source_url; //Field offset: 0x40

	public GetAuthenticateURLResult() { }

}


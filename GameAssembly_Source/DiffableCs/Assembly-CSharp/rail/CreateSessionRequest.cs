namespace rail;

public class CreateSessionRequest : EventBase
{
	public RailID local_peer; //Field offset: 0x30
	public RailID remote_peer; //Field offset: 0x38

	public CreateSessionRequest() { }

}


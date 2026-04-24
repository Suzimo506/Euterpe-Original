namespace rail;

public class CreateSessionFailed : EventBase
{
	public RailID local_peer; //Field offset: 0x30
	public RailID remote_peer; //Field offset: 0x38

	public CreateSessionFailed() { }

}


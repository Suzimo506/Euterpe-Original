namespace rail;

public class EventBase
{
	public RailResult result; //Field offset: 0x10
	public RailGameID game_id; //Field offset: 0x18
	public string user_data; //Field offset: 0x20
	public RailID rail_id; //Field offset: 0x28

	public EventBase() { }

}


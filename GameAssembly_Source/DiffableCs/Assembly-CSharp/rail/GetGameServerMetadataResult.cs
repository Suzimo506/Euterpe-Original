namespace rail;

public class GetGameServerMetadataResult : EventBase
{
	public RailID game_server_id; //Field offset: 0x30
	public List<RailKeyValue> key_value; //Field offset: 0x38

	public GetGameServerMetadataResult() { }

}


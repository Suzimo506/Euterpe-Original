namespace rail;

public class RailFriendsGetMetadataResult : EventBase
{
	public RailID friend_id; //Field offset: 0x30
	public List<RailKeyValueResult> friend_kvs; //Field offset: 0x38

	public RailFriendsGetMetadataResult() { }

}


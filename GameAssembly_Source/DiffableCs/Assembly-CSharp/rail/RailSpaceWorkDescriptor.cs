namespace rail;

public class RailSpaceWorkDescriptor
{
	public List<RailSpaceWorkVoteDetail> vote_details; //Field offset: 0x10
	public string description; //Field offset: 0x18
	public string preview_scaling_url; //Field offset: 0x20
	public string recommendation_rate; //Field offset: 0x28
	public string preview_url; //Field offset: 0x30
	public SpaceWorkID id; //Field offset: 0x38
	public uint create_time; //Field offset: 0x40
	public string detail_url; //Field offset: 0x48
	public List<RailID> uploader_ids; //Field offset: 0x50
	public string name; //Field offset: 0x58

	public RailSpaceWorkDescriptor() { }

}


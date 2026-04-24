namespace rail;

public class AsyncSubscribeSpaceWorksResult : EventBase
{
	public List<SpaceWorkID> success_ids; //Field offset: 0x30
	public List<SpaceWorkID> failure_ids; //Field offset: 0x38
	public bool subscribe; //Field offset: 0x40

	public AsyncSubscribeSpaceWorksResult() { }

}

